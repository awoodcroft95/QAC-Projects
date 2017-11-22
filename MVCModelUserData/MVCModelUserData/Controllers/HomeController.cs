using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCModelUserData.Models;

namespace MVCModelUserData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            StudentClass info = new StudentClass();
            info.Marks = 100;
            info.Name = "John Smith";
            info.RegNo = 1;
            return View(info);
        }

        public ActionResult Index2()
        {
            StudentClass info2 = new StudentClass();
            info2.Marks = 150;
            info2.Name = "Anthony Woodcroft";
            info2.RegNo = 2;
            return View("Index", info2);
        }
    }
}