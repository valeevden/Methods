using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForMethods
{
    public static class HelpWithArray
    {
        public static void DisplaySimpleArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static int[] MakeSimpleArray(int n, int a = -99, int b=99)
        {
            int[] array;
            array = new int[n];

            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(a, b); 
            }
            return array;
        }

        public static int[,] Make2DimensionalArray(int y, int x, int a = -99, int b = 99)
        {
            int[,] array;
            array = new int[y, x];

            Random r = new Random();

            for (int i = 0; i < array.GetLength(0); i++) // Для каждой строки в массиве 
            {
                for (int j = 0; j < array.GetLength(1); j++) // И для каждого столбца
                {
                    array[i, j] = r.Next(a, b); // Вставляем рандомные значения
                }
            }
           return array;
        }

        public static void Display2DimensionalArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++) // Для каждой строки в массиве 
            {
                for (int j = 0; j < array.GetLength(1); j++) // И для каждого столбца
                {
                    Console.Write(array[i, j] + "\t"); // и выводим что получилось c табуляцией
                }
                Console.WriteLine(); // Выводим пустую строку после каждой строчки массива
            }
        }
    }
}

