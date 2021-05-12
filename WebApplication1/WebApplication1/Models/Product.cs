using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        public string ProductName { get; private set; }
        public decimal Price { get; private set; }

        public string Description { get; private set; }

        public Product(string productName, decimal price, string description)
        {
            ProductName = productName;
            Price = price;
            Description = description;
        }
    }
}
