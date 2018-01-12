using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(string email, string password)
        {
            if(email != null && password != null)
            ViewBag.access = true;
            return View();
        }

        public ActionResult SingUp(string email, string userName, string password, string confirmPassword)
        {
            return View();
        }
    }
}