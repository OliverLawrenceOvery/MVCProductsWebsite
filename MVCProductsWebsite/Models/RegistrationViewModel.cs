using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProductsWebsite.Models
{
    public class RegistrationViewModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> RoleId { get; set; }

        public virtual UserRole UserRole { get; set; }
    }
}