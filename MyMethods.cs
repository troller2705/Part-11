using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_11___Methods
{
    internal class MyMethods
    {
        public static double GetHypotenuse(double a, double b)
        {
            double c = Math.Sqrt((a * a) + (b * b));
            return c;
        }
    }
}
