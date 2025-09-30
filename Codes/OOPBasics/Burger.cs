using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Burger : Product
    {
        public bool IsSpicy { get; set; }
        public bool IncludeCheese { get; set; }

        public override void PrintName()
        {
            Console.WriteLine("Name is: " + Name + _id);
        }
    }
}
