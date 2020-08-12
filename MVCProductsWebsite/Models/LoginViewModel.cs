using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProductsWebsite.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please Enter an Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter a Password")]
        public string Password { get; set; }
    }
}