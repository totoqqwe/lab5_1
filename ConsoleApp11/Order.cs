using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Order
    {
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
        public double TotalCost { get; set; }
        public string Status { get; set; }

        public Order(List<Product> products, int quantity, double totalCost, string status)
        {
            Products = products;
            Quantity = quantity;
            TotalCost = totalCost;
            Status = status;
        }
    }
}
