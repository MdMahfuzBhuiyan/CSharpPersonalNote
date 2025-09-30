using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class ShoppingCart
    {
        public IProduct[] Products { get; set; }
        public int ItemCount { get; set; }

        public void ShowCartItems()
        {
            var total = 0.0M;

            foreach (var item in Products)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}");
                total += item.GetDiscountedPrice();
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Total = {total}");
        }
    }
}
