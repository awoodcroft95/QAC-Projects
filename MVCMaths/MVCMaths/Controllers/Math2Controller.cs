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
    }
}