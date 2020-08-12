using MVCProductsWebsite.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCProductsWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult RegisterUser(RegistrationViewModel model)
        {
            ProductDBEntities db = new ProductDBEntities();

            User user = new User()
            {
                Username = model.Username,
                Password = model.Password,
                RoleId = 3
            };
            db.Users.Add(user);
            db.SaveChanges();

            return View();

        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult LoginUser(LoginViewModel model)
        {
            ProductDBEntities db = new ProductDBEntities();
            User user = db.Users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            string result = "fail";
            if (user != null)
            {
                Session["UserId"] = user.UserId;
                Session["UserName"] = user.Username;
                Session["RoleId"] = user.RoleId;
                if (user.RoleId == 3)
                {
                    result = "User";
                }
                else if (user.RoleId == 2)
                {
                    result = "Manager";
                }
                else if (user.RoleId == 1)
                {
                    result = "Admin";
                }
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();

            return RedirectToAction("Index");
        }

        public ActionResult Exec()
        {
            ProductDBEntities db = new ProductDBEntities();
            List<Product> list = db.Products.ToList();
            ViewBag.ProductList = list;

           return View();
        }

        public ActionResult GetSearchRecord(string SearchText)
        {
            ProductDBEntities db = new ProductDBEntities();
            List<ProductViewModel> listProd = db.Products.Where(
                x => x.ProductClass.Contains(SearchText)).Select(x => new ProductViewModel
                { 
                    ProductID = x.ProductID,
                    ProductClass = x.ProductClass,
                    ProductModel = x.ProductModel,
                    Price = x.Price,
                    Supplier = x.Supplier
                }).ToList();

            return PartialView("SearchPartial", listProd);
        }

    }
}