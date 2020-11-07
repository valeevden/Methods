using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForMethods.Tests
{
    public class StructuresTest
    {
    
        [TestCase(1,2,-1)]
        [TestCase(10,6,16)]
        [TestCase(-1,-1,1)]
        public void SolveABTest(int a, int b, int ex)
        {
            int actual = LibraryForMethods.Structure.SolveAB(a, b);
            Assert.AreEqual(ex, actual);
        }

        [TestCase(1, 2, 1)]
        [TestCase(-10, 6, 2)]
        [TestCase(-1, -1, 3)]
        [TestCase(15, -1, 4)]
        public void FindCoordinateQuarterTest(int a, int b, int ex)
        {
            int actual = LibraryForMethods.Structure.FindCoordinateQuarter(a, b);
            Assert.AreEqual(ex, actual);
        }

        [TestCase(3, 1, 2, new int[3] { 1, 2, 3 })]
        [TestCase(6, 0, -7, new int[3] { -7, 0, 6 })]
        [TestCase(-5, 22, -12, new int[3] { -12, -5, 22 })]
        public void SortABCandMakeArrayABCTest(int a, int b, int c, int [] expected)
        {
            int [] actual = LibraryForMethods.Structure.SortABCandMakeArrayABC(a, b, c);
            Assert.AreEqual(expected, actual);
        }



    }
}
