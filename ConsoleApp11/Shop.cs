using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Shop : ISearchable
    {
        private List<User> users;
        private List<Product> products;
        private List<Order> orders;

        public Shop()
        {
            users = new List<User>();
            products = new List<Product>();
            orders = new List<Order>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Available Products:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - ${product.Price} - Category: {product.Category} - Rating: {product.Rating}");
            }
            Console.WriteLine();
        }

        public void DisplayUsers()
        {
            Console.WriteLine("Registered Users:");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Username}");
            }
            Console.WriteLine();
        }

        public void DisplayOrders()
        {
            Console.WriteLine("Orders:");
            foreach (var order in orders)
            {
                Console.WriteLine($"Order Status: {order.Status}");
                foreach (var product in order.Products)
                {
                    Console.WriteLine($"{product.Name} - ${product.Price} - Quantity: {order.Quantity} - Total: ${order.TotalCost}");
                }
                Console.WriteLine();
            }
        }

        public List<Product> SearchByPrice(double maxPrice)
        {
            return products.Where(p => p.Price <= maxPrice).ToList();
        }

        public List<Product> SearchByCategory(string category)
        {
            return products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Product> SearchByRating(double minRating)
        {
            return products.Where(p => p.Rating >= minRating).ToList();
        }
    }
}
