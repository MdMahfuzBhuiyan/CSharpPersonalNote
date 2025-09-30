using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public class Burger : Product
    {
        public int Size { get; set; }
        public string Flavour { get; set; }

        public override double CalculatePrice(int factor)
        {
            if (Size > 5)
                Price = 200;
            else
                Price = 100;

            return Price / factor;
        }
    }
}
