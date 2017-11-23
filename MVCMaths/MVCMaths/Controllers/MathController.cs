using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMaths.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Main()
        {
            return View();
        }

        public ActionResult Operations(int no1, int no2, String operation)
        {
            float c = 0;
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
            else if (operation.Equals("mult"))
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