using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineika
{
    public class DiscriminantFinder
    {
        public static int GetDiscriminant(int[] obj)
        {
            return obj[1] * obj[1] - 4 * obj[0] * obj[2];
        }
    }
}
