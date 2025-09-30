using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    public partial class Product : Item
    {
        public double GetPriceAfterDiscount(int discount)
        {
            return Price - (Price * discount / 100);
        }
    }
}
