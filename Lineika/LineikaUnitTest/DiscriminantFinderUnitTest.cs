using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LineikaUnitTest
{
    [TestClass]
    public class DiscriminantFinderUnitTest
    {
        [TestMethod]
        public void IsCorrectDiscriminant()
        {
            int[] coefs = { 1, 3, 2 };
            Assert.AreEqual(1, Lineika.DiscriminantFinder.GetDiscriminant(coefs));
        }
    }
}
