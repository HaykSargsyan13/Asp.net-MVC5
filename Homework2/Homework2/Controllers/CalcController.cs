using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework2.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Add(int? x, int? y)
        {
            ViewBag.Add = x + y;
            return View();
        }

        public ActionResult Mul(int? x, int? y)
        {
            ViewBag.Mul = x * y;
            return View();
        }
        public ActionResult Sub(int? x, int? y)
        {
            ViewBag.Sub = x - y;
            return View();
        }
        public ActionResult Div(int? x, int? y)
        {
            if(y != 0)
            ViewBag.Div = x / y;
            return View();
        }
    }
}