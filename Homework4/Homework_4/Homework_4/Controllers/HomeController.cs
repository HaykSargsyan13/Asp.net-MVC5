using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            if (id != null)
            {
                ViewBag.messege = id;
                return View();
            }
            else
            return View();
        }

        //[HttpPost]

        //public ActionResult Index(string id)
        //{
        //    return View()
        //}
    }
}