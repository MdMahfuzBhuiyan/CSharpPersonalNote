using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Counter
    {
        // another name of static is shared
        public static int Count { get; set; } 

        public void IncreaseCounter()
        {
            Count++;
        }

        public void PrintCounter()
        {
            Console.WriteLine(Count);
        }
    }
}
