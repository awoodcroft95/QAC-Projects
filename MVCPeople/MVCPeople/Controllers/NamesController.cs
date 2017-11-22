using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPeople.Controllers
{
    public class NamesController : Controller
    {
        // GET: Names
        public ActionResult Peter()
        {
            return View();
        }

        public ActionResult Smith()
        {
            return View();
        }
    }
}