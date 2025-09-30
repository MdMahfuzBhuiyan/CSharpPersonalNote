using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public abstract double CalculatePrice(int factor);

        public string MakeShortName (int size)
        {
            return Name.Substring(0, size);
        }
    }
}
