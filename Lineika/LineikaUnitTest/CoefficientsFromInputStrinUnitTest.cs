using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LineikaUnitTest
{
    [TestClass]
    public class CoefficientsFromInputStrinUnitTest
    {
        [TestMethod]
        public void IsCorrectCoefficients()
        {
            int[] reality = Lineika.CoefficientsFromInputString.GetCoefficients("4*x^2+-2*x+-15=0");
            Console.WriteLine(reality[0].ToString() + ' ' + reality[1].ToString() + ' ' + reality[2].ToString() + ' ');
            Assert.AreEqual(new int[] { 4, -2, -15 }, reality);
        }
    }
}
