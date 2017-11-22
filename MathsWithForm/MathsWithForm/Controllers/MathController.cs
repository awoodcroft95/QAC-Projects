using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MathsWithForm.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculations(int no1, int no2)
        {
            int no3 = no1 + no2; ;
            ViewData["Result"] = no3;
            return View("ProcessData");
        }
    }
}