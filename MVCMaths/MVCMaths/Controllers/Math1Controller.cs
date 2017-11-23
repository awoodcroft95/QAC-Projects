using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMaths.Controllers
{
    public class Math1Controller : Controller
    {
        // GET: Math1
        public ActionResult Add()
        {
            ViewData["opt"] = "add";
            return View("InputForm");
        }

        public ActionResult Sub()
        {
            ViewData["opt"] = "sub";
            return View("InputForm");
        }

        public ActionResult Operations(int no1, int no2, String operation)
        {
            int c = 0;
            if (operation.Equals("add"))
            {
                c = no1 + no2;
                ViewData["C"] = "Addition";
            }
            else if (operation.Equals("sub"))
            {
                c = no1 - no2;
                ViewData["C"] = "Subtraction";
            }

            ViewData["A"] = no1;
            ViewData["B"] = no2;
            ViewData["D"] = c;
            return View();
        }
    }
}