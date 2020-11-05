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
        
        [TestCase(2, 15, 27, 6)]
        [TestCase(2, 15, 0, -7.5)]
        [TestCase(3, 0, 27, 9)]
        public void FindSolutionForEquationTest(int a, int b, int c, double expected)
        {
            
            double actual = LibraryForMethods.Variable.FindSolutionForEquation(a, b,c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, 2)]
        public void FindSolutionForEquationNegative(int a, int b, int c)
        {
            try
            {
                LibraryForMethods.Variable.FindSolutionForEquation(a,b,c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(10,2,new int [] {5,0} )]
        [TestCase(77,2,new int [] {38,1} )]
        [TestCase(111,10,new int [] {11,1} )]
        public void MakeDivisionAandModATest(int a, int b, int [] expected)
        {
            int[] array = LibraryForMethods.Variable.MakeDivisionAandModA(a, b);
            Assert.AreEqual(expected, array);
        }

        [TestCase(1, 0)]
        public void MakeDivisionAandModANegative(int a, int b)
        {
            try
            {
                LibraryForMethods.Variable.MakeDivisionAandModA(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
