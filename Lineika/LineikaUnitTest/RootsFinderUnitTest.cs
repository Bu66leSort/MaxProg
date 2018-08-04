using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LineikaUnitTest
{
    [TestClass]
    public class RootsFinderUnitTest
    {
        [TestMethod]
        public void IsCorrectParameter_X1()
        { 
            double x1_real = Lineika.RootsFinder.GetX1(new int[] { 1, 3, -4 }, Lineika.DiscriminantFinder.GetDiscriminant);
            Assert.AreEqual(1, x1_real);
        }

        [TestMethod]
        public void IsCorrectParameter_X2()
        {
            double x2_real = Lineika.RootsFinder.GetX2(new int[] { 1, 3, -4 }, Lineika.DiscriminantFinder.GetDiscriminant);
            Assert.AreEqual(-4, x2_real);
        }

        //ля, почему тут можно совать функцию в аргументы, а в изначальной функции RootsFinder низя, втф
    }
}
