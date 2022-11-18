using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelf_life
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> product = new List<Products>();
            {
                new Products("Milk",10,14);
                new Products("Cheese",20,17);
                new Products("Bread",4,10);
                new Products("Tomatoes",15,19);
                new Products("Cucumbers",15,18);
            }
            var time = product.Where(item => item.Time >= item.Expirationdate).ToList();
            foreach (var item in time)
            {
                Console.WriteLine($"Просроченные продукты: {item.Name}");

            }
            Console.ReadKey();
        }

    }
}
