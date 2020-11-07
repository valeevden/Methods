using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForMethods.Tests
{
    public class CyclesTest
    {
        [TestCase(2, 2, 4)]
        [TestCase(3, 3, 27)]
        [TestCase(5, 5, 3125)]
        public void DoSqrtABTest(int a, int b, int ex)
        {
            int ac = LibraryForMethods.Cycles.DoSqrtAB(a, b);
            Assert.AreEqual(ac, ex);
        }

        [TestCase(300, new int[] { 300, 600, 900 })]
        [TestCase(400, new int[] { 400, 800 })]
        public void MakeArrayMOD_A_from1to1000Equals0CTest(int a, int[] expected)
        {
            int[] actual = LibraryForMethods.Cycles.MakeArrayMOD_A_from1to1000Equals0(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 300, 600, 900 })]
        [TestCase(0, new int[] { 400, 800 })]
        public void MakeArrayMOD_A_from1to1000Equals0CNegative(int a, int[] expected)
        {
            try
            {
                int[] actual = LibraryForMethods.Cycles.MakeArrayMOD_A_from1to1000Equals0(a);
            }
            catch (Exception)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(12345, 67890, false)]
        [TestCase(12345, 16789, true)]
        [TestCase(0, 100, true)]
        [TestCase(0, 0, true)]
        [TestCase(-1, 1, true)]
        public void AreNumbersHaveEqualDigitsTest(int a, int b, bool expected)
        {
            bool actual = LibraryForMethods.Cycles.AreNumbersHaveEqualDigits(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
