using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_5.Models
{
    public static class Products
    {
        private static List<Product> _products = null;

        public static List<Product> products
        {
            get
            {
                if(_products == null)
                {
                    _products = new List<Product>();
                    for (int i = 1; i < 6; i++)
                    {
                        Product pr = new Product();
                        pr.Id = i;
                        pr.Name = "Name" + pr.Id.ToString() + " ";
                        pr.Price = pr.Id * 100;
                        pr.Description = pr.Name + pr.Price.ToString();
                        _products.Add(pr);
                    }
                   
                 }
                return _products;
            }
        }
    }


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}