using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop myShop = new Shop();

            User user1 = new User("user1", "password1");
            User user2 = new User("user2", "password2");

            myShop.AddUser(user1);
            myShop.AddUser(user2);

            Product product1 = new Product("Laptop", 1200, "High-performance laptop", "Electronics", 4.5);
            Product product2 = new Product("Headphones", 100, "Noise-canceling headphones", "Electronics", 4.0);
            Product product3 = new Product("Backpack", 40, "Durable backpack", "Fashion", 3.8);

            myShop.AddProduct(product1);
            myShop.AddProduct(product2);
            myShop.AddProduct(product3);

            myShop.DisplayProducts();
            myShop.DisplayUsers();

            List<Product> searchResults = myShop.SearchByPrice(150);
            Console.WriteLine("Search Results:");
            foreach (var result in searchResults)
            {
                Console.WriteLine($"{result.Name} - ${result.Price} - Category: {result.Category} - Rating: {result.Rating}");
            }
        }
    }
}
