using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework3.Models
{
    public class ProductCollection
    {
        public static List<Product> All
        {
            get
            {
                List<Product> products = new List<Product>();
                for (int i = 0; i < 20; i++)
                {
                    products.Add(new Product
                    {
                        Id = i + 1,
                        Name = "Item Name" + 1,
                        Price = i * 123 + 100,
                        CreateTime = DateTime.Now
                    });
                }
                return products;
            }
        }
    }
}