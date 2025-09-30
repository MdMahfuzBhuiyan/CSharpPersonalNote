using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Numbers
    {
        public int[] NumberItems { get; set; }

        public virtual void Print(int count)
        {
            foreach (int item in NumberItems)
            {
                {
                    if (item > count)
                        Console.WriteLine(item);
                }
            }
        }

        public virtual void Replace(int num)
        {
            for (int i = 0; i < NumberItems.Length; i++)
            {
                if (NumberItems[i]== num)
                    NumberItems[i] = 0;
            }
        }
    }
}
