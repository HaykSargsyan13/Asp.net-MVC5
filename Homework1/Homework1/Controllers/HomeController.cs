using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homework1.Models;

namespace Homework1.Controllers
{
    public class HomeController : Controller
    {
        List<Product> list = new List<Product>();
        
        // GET: Home
        public ActionResult Index()
        {
            list.Add(new Product
            {
                Id = 1,
                Name = "Ball",
                Price = 2000,
                Description = "Sport"
            });
            list.Add(
                new Product
                {
                    Id = 2,
                    Name = "Apple",
                    Price = 359.3m,
                    Description = "Fruit"
                });
            list.Add(
               new Product
               {
                   Id = 3,
                   Name = "Pen",
                   Price = 100,
                   Description = "School"
               });
            return View(list);
        }
    }
}