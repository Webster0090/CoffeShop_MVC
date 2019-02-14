using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffee_Shop_MVC.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string CoffeeType { get; set; }
    }
}