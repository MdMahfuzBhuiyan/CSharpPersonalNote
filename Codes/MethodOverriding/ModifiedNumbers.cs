using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class ModifiedNumbers : Numbers
    {
        public new void Print(int count)
        {
            foreach(var item in NumberItems)
            {
                if(item >= count)
                    Console.WriteLine(item);
            }
        }

        public override void Replace(int num)
        {
            base.Replace(num);
        }
    }
}
