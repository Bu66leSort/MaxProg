using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lineika
{
    class ZeProgram
    {
        static void Main()
        {
            Console.Write("Enter your equation, example: 4*x^2+-3*x+-15=0 \nEquation: ");
            string equation = Console.ReadLine();
            while(!CheckInputString.IsCorrectString(equation))
            {
                Console.WriteLine("LOL, it is wrong((0( Try again\nEquation: ");
                equation = Console.ReadLine();
            }
            int[] parameters = CoefficientsFromInputString.GetCoefficients(equation);
            int discriminant = DiscriminantFinder.GetDiscriminant(parameters);
            double x1, x2;
            if (discriminant > 0)
            {
                x1 = RootsFinder.GetX1(parameters, DiscriminantFinder.GetDiscriminant); // BECAUSE I WANT
                x2 = RootsFinder.GetX2(parameters, DiscriminantFinder.GetDiscriminant);
            }
            else if (discriminant == 0)
            {
                x1 = RootsFinder.GetX1(parameters, DiscriminantFinder.GetDiscriminant);
                x2 = x1;
            }
            else
            {
                Console.WriteLine("There are not real roots");
                return;
            }

            Console.WriteLine("x1: {0} \nx2: {1}", x1, x2);
        }
    }
}
