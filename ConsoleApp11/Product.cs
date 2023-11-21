using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Rating { get; set; }

        public Product(string name, double price, string description, string category, double rating)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            Rating = rating;
        }
    }
}
