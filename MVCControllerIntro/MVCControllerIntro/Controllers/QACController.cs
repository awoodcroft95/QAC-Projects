using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCControllerIntro.Controllers
{
    public class QACController : Controller
    {
        // GET: QAC
        public ActionResult AboutUs()
        {
            return View("About1");
        }

        public ActionResult AboutUs2()
        {
            return View("About2");
        }
    }
}