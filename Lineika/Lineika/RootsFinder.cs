using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineika
{
    public class RootsFinder
    {
        public delegate int discriminantFunc(int[] coefs);  // why??? BECAUSE I WANT

        public static double GetX1(int[] obj, discriminantFunc f)
        {
            return (-obj[1] + Math.Sqrt(f(obj))) / 2 * obj[0];
        }

        public static double GetX2(int[] obj, discriminantFunc f)
        {
            return (-obj[1] - Math.Sqrt(f(obj))) / 2 * obj[0];
        }
    }
}
