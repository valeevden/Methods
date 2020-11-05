using NUnit.Framework;
using LibraryForMethods;

namespace LibraryForMethods.Tests
{
    public class VariablesTest
    {
        [Test]
      public void SolveTheEquationTest()
        {
            double expected = 9;
            double actual = LibraryForMethods.Variable.SolveTheEquation(1,2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,-3,-3.5)]
        [TestCase(2,3,19)]
        [TestCase(5,6,61)]
        public void SolveTheEquationTest2(int a, int b, double expected)
        {
            //double expected = 9;
            double actual = LibraryForMethods.Variable.SolveTheEquation(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase (1,1)]
        public void SolveTheEquationNegative(int a, int b)
        {
            try
            {
            LibraryForMethods.Variable.SolveTheEquation(a, b);
            }
            catch
            {
            Assert.Pass();
            }
                Assert.Fail();
        }

    }
}