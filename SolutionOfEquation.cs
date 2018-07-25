using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lineika
{
    public class SolutionOfEquation
    {
        public SolutionOfEquation(ref string a, ref string b, ref string c)
        {
            Regex templateForInput = new Regex(@"^[+-]?\d*$");
            while (!templateForInput.IsMatch(a) || !templateForInput.IsMatch(b) || !templateForInput.IsMatch(c))
            {
                Console.WriteLine("\nIncorrect, try again!");
                a = Console.ReadLine();
                b = Console.ReadLine();
                c = Console.ReadLine();
                Console.WriteLine("_______");
            }                         
            string coefficients = a + '/' + b + '/' + c;
            string replacement = a + " * x^2 + " + b + " * x + " + c + " = 0";
            Console.WriteLine(Regex.Replace(coefficients, @"[+-]?\d+\/[+-]?\d+\/[+-]?\d+", replacement));
        }

        public double[] Solution(string a, string b, string c)
        {
            double[] answers = { 0, 0 };
            double dis = int.Parse(b) * int.Parse(b) - 4 * int.Parse(a) * int.Parse(c);
            if (dis > 0)
            {
                answers[0] = (-Convert.ToDouble(b) + Math.Sqrt(dis)) / 2 * Convert.ToDouble(a);
                answers[1] = (-Convert.ToDouble(b) - Math.Sqrt(dis)) / 2 * Convert.ToDouble(a);
                return answers;
            }
            else if (dis == 0)
            {
                answers[0] = -Convert.ToDouble(b) / 2 * Convert.ToDouble(a);
                answers[1] = answers[0];
                return answers;
            }
            else
            {
                Console.WriteLine("There are not real roots");
                return null;
            }
        }
    }
}
