using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public sealed class AnotherNumber : ModifiedNumbers
    {
        public sealed override void Replace(int num)
        {
            base.Replace(num);
        }
    }
}
