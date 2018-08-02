using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineika
{
    class CoefficientsFromInputString
    {
        public static int[] GetCoefficients(string str)
        {
            int step = 0;
            int[] coefs = new int[3];
            string coef = "";
            for (int i = 0; i < str.Length - 1; i++)
            {
                if ((str[i] > 47 && str[i] < 58) || (str[i - 1] == '+' && str[i] == '-'))
                {
                    if (str[i] == '2')
                    {
                        if (str[i - 1] == '^')
                            continue;
                    }
                    coef += str[i];
                }
                else if(coef != "")
                {
                    coefs[step++] = int.Parse(coef);
                    coef = "";
                }
            }
            return coefs;
        }
    }
}
