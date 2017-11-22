using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLogin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogIn(string username, string pass)
        {
            if (username.Equals("admin") && pass.Equals("admin"))
            {
                return View("Inbox");
            }
            else
            {
                return View("SignUp");
            }
            
        }

        public ActionResult CreateAccount()
        {
            return View();
        }
    }
}