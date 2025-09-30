using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Product
    {
        protected string _id;
        public string Name { get; set; }
        public double Price { get; set; }
        public double[]? Sizes { get; set; }

        public Product()
        {
            Name = string.Empty;
            Sizes = new double[5];
        }

        ~Product()
        {
            Sizes = null;
            Console.WriteLine("Finalizer called");
        }

        public double CalculateDiscount(double discount)
        {
            return Price - (Price * discount);
        }

        public double CalculateDiscount(double discount, double maximumDiscount)
        {
            var dis = Price * discount;
            if(dis > maximumDiscount)
                dis= maximumDiscount;
            return Price - Price * dis;
        }

        public double CalculateDiscount(double discount, int maximumDiscount)
        {
            throw new NotImplementedException();
        }

        public double CalculateDiscount(int maximumDiscount, double discount)
        {
            throw new NotImplementedException();
        }

        public virtual void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}
