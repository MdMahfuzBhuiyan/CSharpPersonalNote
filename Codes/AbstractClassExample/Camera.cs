using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public class Camera : Product
    {
        public string Brand { get; set; }
        public double Pixel { get; set; }
        public double Memory { get; set; }

        public override double CalculatePrice(int factor)
        {
            if (Pixel > 10 && Brand == "Cannon")
                Price = 50000;
            else
                Price = 30000;

            return Price / factor;
        }
    }
}
