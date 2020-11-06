using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForMethods.Tests
{
    public class Array2DimensionalTest
    {
        [TestCase(1, 1)]
        [TestCase(2, -15)]
        [TestCase(3, -34)]
        [TestCase(4, 0)]
        public void FindMin2DArrayUnitTest(int MockNumber, int expected)
        {
            int actual = Array2Dimensional.FindMin2DArrayUnit(GetArrayMock(MockNumber));

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 13)]
        [TestCase(3, 78)]
        [TestCase(4, 0)]
        public void FindMax2DArrayUnitTest(int MockNumber, int expected)
        {
            int actual = Array2Dimensional.FindMax2DArrayUnit(GetArrayMock(MockNumber));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 2, 2 })]
        [TestCase(2, new int[] { 1, 0 })]
        [TestCase(3, new int[] { 1, 3 })]
        [TestCase(4, new int[] { 0, 0 })]
        public void FindMax2DArrayUnitIndexTest(int MockNumber, int[] expected)
        {
            int[] actual = Array2Dimensional.FindMax2DArrayUnitIndex(GetArrayMock(MockNumber));

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        public void MakeNewTransposedArrayTest(int GetActualArrayMockNumber, int GetExpectedArrayMockNumber)
        {
            int[,] actual = Array2Dimensional.MakeNewTransposedArray(GetArrayMock(GetActualArrayMockNumber));
            int[,] expected = GetExpMock(GetExpectedArrayMockNumber);
            Assert.AreEqual(expected, actual);
        }


        // Здесь создается  Мок двумерного массива на вход теста
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
        // А здесь Мок двумерного массива на выход дял транспорирования
        int[,] GetExpMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        {1,4,7},
                        {2,5,8},
                        {3,6,9}
                    };
                case 3:
                    return new int[,]
                    {
                        {0,-6,33},
                        {12,34,22},
                        {6,8,12},
                        {-34,78,-3}
                    };
                case 4:
                    return new int[,]
                    {
                        {0,0},
                        {0,0},
                    };
                default:
                    throw new Exception();
            }

        }
    }
}
