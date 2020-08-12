using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProductsWebsite.Models
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductClass { get; set; }
        public string ProductModel { get; set; }
        public string Price { get; set; }
        public string Supplier { get; set; }
    }
}