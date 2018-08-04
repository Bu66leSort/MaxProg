using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LineikaUnitTest
{
    [TestClass]
    public class CheckInputStringUnitTest
    {
        [TestMethod]
        public void CorrectInputString()
        {
            var str = "4*x^2+-3*x+-15=0";
            bool yepOrNope = Lineika.CheckInputString.IsCorrectString(str);
            Assert.AreEqual(true, yepOrNope);
        }

        [TestMethod]
        public void WrongInputString1()
        {
            var str = "4*x^2+-3*x-15=0";
            bool yepOrNope = Lineika.CheckInputString.IsCorrectString(str);
            Assert.AreEqual(false, yepOrNope);
        }

        [TestMethod]
        public void WrongInputString2()
        {
            var str = "Leha_pedik";
            bool yepOrNope = Lineika.CheckInputString.IsCorrectString(str);
            Assert.AreEqual(false, yepOrNope);
        }

        [TestMethod]
        public void WrongInputString3()
        {
            var str = "3*x^2+-5*x-15";
            bool yepOrNope = Lineika.CheckInputString.IsCorrectString(str);
            Assert.AreEqual(false, yepOrNope);
        }
    }
}
