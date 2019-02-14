using Coffee_Shop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coffee_Shop_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Result(User u)
        {
            if (u.Password != u.ConfirmPassword)
            {
                ViewBag.MessagePassword = "I'm sorry, your password does not match.";
                return View("Register");
            }
            ViewBag.FirstName = u.FirstName;
            ViewBag.CoffeeType = u.CoffeeType;
            return View();
        }
    }
}