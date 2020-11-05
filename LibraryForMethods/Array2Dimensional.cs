using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForMethods
{
    public static class Array2Dimensional
    {
        public static int FindMin2DArrayUnit(int[,] array)
        {
            int min = array[0, 0]; // Задаем переменную для минимального элемента, приравниваем ее к первому элементу массива

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                        min = array[i, j]; // если значение по какому-л индексу оказалось меньше min, то присваеваем min это значение
                }
            }
            return min;
        }

        public static int FindMax2DArrayUnit(int[,] array)
        {
            int max = array[0, 0]; 

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                        max = array[i, j]; 
                }
            }
            return max;
        }

        public static int [] FindMin2DArrayUnitIndex(int[,] array)
        {
            int min = array[0, 0]; // Задаем переменную для минимального элемента, приравниваем ее к первому элементу массива
            int[] index = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j]; // если значение по какому-л индексу оказалось меньше min, то присваеваем min это значение
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
            return index;
        }

        public static int[] FindMax2DArrayUnitIndex(int[,] array)
        {
            int max = array[0, 0]; // Задаем переменную для максимального элемента, приравниваем ее к первому элементу массива
            int[] index = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j]; // если значение по какому-л индексу оказалось больше max, то присваеваем max это значение
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
            return index;
        }

        public static int FindNumberMaxBetweenNeighborsElementInArray(int[,] array)
        {
            int counter = 0; // Задаем счетчик

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    bool sravniSverhu = (i == 0) || (array[i, j] > array[i - 1, j]); // Для всей верхней строки ИЛИ если элемент больше элемента над ним
                    bool sravniSnizu = (i == array.GetLength(0) - 1) || (array[i, j] > array[i + 1, j]); // Для всей нижней строки ИЛИ если элемент больше элемента под ним
                    bool sravniSleva = (j == 0) || (array[i, j] > array[i, j - 1]); // Для всего левого столбца ИЛИ если элемент больше элемента слева от него 
                    bool sravniSprava = (j == array.GetLength(1) - 1) || (array[i, j] > array[i, j + 1]); // Для всего правого столбца  ИЛИ если элемент больше элемента справа от него

                    if (sravniSverhu && sravniSnizu && sravniSleva && sravniSprava) // Если сверху И снизу И слева И справа элемент оказался больше своих соседей, то считаем его
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public static int[,] MakeNewTransposedArray(int[,] array)
        {
            int y = array.GetLength(0);
            int x = array.GetLength(1);
            int[,] array2;
            array2 = new int[x, y];

            for (int i = 0; i < y; i++) // Для каждой строки в массиве 
            {
                for (int j = 0; j < x; j++) // И для каждого столбца
                {
                    array2[j, i] = array[i, j]; // Заполняем второй массив
                }
            }
            return array2;
        }
    }
}
