using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public static class Geometry
    {
        private static double _pi;

        public static double PI { get { return _pi; } }

        static Geometry()
        {
            _pi = 22 / 7;
        }

        public static double CalculateCircleArea(double radius)
        {
            return _pi * radius * radius;
        }
    }
}
