using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForMethods.Tests
{
     public class Array2DimensionalTest
     {
        [TestCase(1,1)]
        [TestCase(2,-15)]
        [TestCase(3,-34)]
        [TestCase(4,0)]
        public void FindMin2DArrayUnit(int MockNumber, int expected)
        {
            int actual = LibraryForMethods.Array2Dimensional.FindMin2DArrayUnit(GetArrayMock(MockNumber));
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 13)]
        [TestCase(3, 78)]
        [TestCase(4, 0)]
        public void FindMax2DArrayUnit(int MockNumber, int expected)
        {
            int actual = LibraryForMethods.Array2Dimensional.FindMax2DArrayUnit(GetArrayMock(MockNumber));

            Assert.AreEqual(expected, actual);
        }

        int[,] GetArrayMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        {1,2,3},
                        {4,5,6},
                        {7,8,9}
                    };
                case 2:
                    return new int[,]
                    {
                        {4,6,8},
                        {13,2,11},
                        {-15,4,-4}
                    };
                case 3:
                    return new int[,]
                    {
                        {0,12,6,-34},
                        {-6,34,8,78},
                        {33,22,12,-3}
                    };
                case 4:
                    return new int[,]
                    {
                        {0,0},
                        {0,0,},
                    };
                default:
                    throw new Exception();
            }
            

        }
    }
}
