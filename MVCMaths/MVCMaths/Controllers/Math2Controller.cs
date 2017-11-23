using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMaths.Controllers
{
    public class Math2Controller : Controller
    {
        // GET: Math2
        public ActionResult Multiply()
        {
            ViewData["opt"] = "mult";
            return View("InputForm");
        }

        public ActionResult Divide()
        {
            ViewData["opt"] = "div";
            return View("InputForm");
        }

        public ActionResult Operations(int no1, int no2, String operation)
        {
            float c = 0;
            if (operation.Equals("mult"))
            {
                c = no1 * no2;
                ViewData["C"] = "Multiplication";
            }
            else if (operation.Equals("div"))
            {
                c = (float)no1 / no2;
                ViewData["C"] = "Division";
            }

            ViewData["A"] = no1;
            ViewData["B"] = no2;
            ViewData["D"] = c;
            return View();
        }
    }
}