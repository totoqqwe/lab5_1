using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal interface ISearchable
    {
        List<Product> SearchByPrice(double maxPrice);
        List<Product> SearchByCategory(string category);
        List<Product> SearchByRating(double minRating);
    }
}
