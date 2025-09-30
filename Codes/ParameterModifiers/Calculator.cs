using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifiers
{
    public class Calculator
    {
        public int Sum(params int[] items)
        {
            var sum = 0;
            foreach(var item in items) 
                sum += item;

            return sum;
        }

        public void InsertValue(in int x)
        {
            //x = 3;
        }

        public void InsertValue2(out Person x)
        {
            x = new Person();
            x.IncreaseAge();
        }

        public void InsertValue3(ref Person x)
        {
            x.IncreaseAge();
        }
    }
}
