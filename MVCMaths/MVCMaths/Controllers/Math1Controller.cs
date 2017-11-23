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
    }
}