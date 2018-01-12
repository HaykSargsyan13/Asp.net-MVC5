using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework6._1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Homework6._1.Models.UserInfo model)
        {
            Debug.WriteLine("Id : " + model.Id);
            Debug.WriteLine("Name : " + model.Name);
            Debug.WriteLine("BornDate: " +  model.BornDate);
            Debug.WriteLine("Company : " + model.Company);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}