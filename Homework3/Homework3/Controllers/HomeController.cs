using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homework3.Models;

namespace Homework3.Controllers
{
    public class HomeController : Controller
    {
        

        // GET: Home
        public ActionResult Index(int n = 5)
        {
            return View();
        }

        public ActionResult ShowTable(int n = 5)
        {
            IEnumerable<Product> list = ProductCollection.All.Take(n);
            return PartialView("_Table", list);
        }
        public ActionResult ShowList(int n = 5)
        {
            IEnumerable<Product> list = ProductCollection.All.Take(n);
            return PartialView("_List", list);
        }
    }
}