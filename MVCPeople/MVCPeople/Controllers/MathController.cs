using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPeople.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Add(int a, int b)
        {
            int c = a + b;
            ViewData["num1"] = a;
            ViewData["num2"] = b;
            ViewData["num3"] = c;
            ViewData["Result"] = (c > 50) ? "You Passed" : "You Failed";
            return View("MathResult");
        }
        public ActionResult Subtract(int a, int b)
        {
            int c = a - b;
            ViewData["num1"] = a;
            ViewData["num2"] = b;
            ViewData["num3"] = c;
            ViewData["Result"] = (c > 50) ? "You Passed" : "You Failed";
            return View("MathResult");
        }

        public ActionResult Multiply(int a, int b)
        {
            int c = a * b;
            ViewData["num1"] = a;
            ViewData["num2"] = b;
            ViewData["num3"] = c;
            ViewData["Result"] = (c > 50) ? "You Passed" : "You Failed";
            return View("MathResult");
        }

        public ActionResult Divide(int a, int b)
        {
            float c = (float) a / b;
            ViewData["num1"] = a;
            ViewData["num2"] = b;
            ViewData["num3"] = c;
            ViewData["Result"] = (c > 50) ? "You Passed" : "You Failed";
            return View("MathResult");
        }
    }
}