using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lineika
{
    class CheckInputString
    {
        public static bool IsCorrectString(string obj)
        {
            return Regex.IsMatch(obj, @"^\-?[1-9]\d*\*x\^2\+\-?[1-9]\d*\*x\+\-?[1-9]\d*\=0$", RegexOptions.IgnoreCase);
        }
    }
}
