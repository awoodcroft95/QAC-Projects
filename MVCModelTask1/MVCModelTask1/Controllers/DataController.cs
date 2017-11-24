using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCModelTask1.Models;

namespace MVCModelTask1.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Process(Info x)
        {
            if(x.marks == 58 || x.marks == 59)
            {
                x.marks = 60;
            }
            Console.Write(x.name);
            return View("results", x);
        }
    }
}