using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework5._1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(char c , int x = 0, int y = 0)
        {
            int result = 0;
            if (c == '+')
                result = x + y;
            else if (c == '-')
                result = x - y;
            else if (c == '*')
                result = x * y;
            else if (c == '/')
                result = x / y;
            ViewBag.result = result;
            return View();
        }
        
    }
}