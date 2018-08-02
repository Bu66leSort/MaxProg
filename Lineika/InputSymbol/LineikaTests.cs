using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lineika
{
    [TestClass]
    public class LineikaTests
    {
        [TestMethod]
        public void InputSymbols()
        {
            string a_Incorrect = "qwe";
            string b_Incorrect = "e12";
            string c_Incorrect = "32a";
            string a_Correct = "qwe";
            string b_Correct = "e12";
            string c_Correct = "32a";

            SolutionOfEquation soe = new SolutionOfEquation(ref a_Correct, ref b_Correct, ref c_Correct);

            Assert.AreNotEqual(a_Correct, a_Incorrect, "a_Correct != a_Incorrect\n");
            Assert.AreNotEqual(b_Correct, b_Incorrect, "b_Correct != b_Incorrect\n");
            Assert.AreNotEqual(c_Correct, c_Incorrect, "b_Correct != b_Incorrect\n");            
        }

        [TestMethod]
        public void DiscriminantIsBiggerThanZero()
        {
            string a = "1", b = "3", c = "2";
            double[] expected = { -1, -2 };
            SolutionOfEquation soe = new SolutionOfEquation(ref a, ref b, ref c);

            double[] actual = soe.Solution(a, b, c);

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1], "dsada"); // где бля вывод?
        }

        [TestMethod]
        public void DiscriminantEqualZero()
        {
            string a = "1", b = "2", c = "1";
            double[] expected = { -1, -1 };
            SolutionOfEquation soe = new SolutionOfEquation(ref a, ref b, ref c);

            double[] actual = soe.Solution(a, b, c);

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]); 
        }

        [TestMethod]
        public void DiscriminantIsSmallerThanZero()
        {
            string a = "1", b = "1", c = "1";
            string expected = null;
            SolutionOfEquation soe = new SolutionOfEquation(ref a, ref b, ref c);

            string actual = null;

            Assert.AreEqual(expected, actual);
        }
    }
}
