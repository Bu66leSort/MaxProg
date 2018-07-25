using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lineika
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Your coefficients?");
            string a = Console.ReadLine(), b = Console.ReadLine(), c = Console.ReadLine();
            SolutionOfEquation soe = new SolutionOfEquation(ref a, ref b, ref c);
            double[] answers = new double[2];
            answers = soe.Solution(a, b, c);
            Console.WriteLine();
            if (answers != null)
            {
                Console.WriteLine("x1 = {0}\nx2 = {1}", answers[0].ToString(), answers[1].ToString());
            }
        }
    }
}
