using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForMethods
{
    public static class ArraySimple
    {
        public static int FindMinArrayUnit (int [] array)
        {
            int min = array[0]; // Задаем переменную для минимального элемента, приравниваем ее к первому элементу массива

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i]; // если значение по какому-л индексу оказалось меньше min, то присваеваем min это значение
                }
            }
            return min;
        }

        public static int FindMaxArrayUnit(int[] array)
        {
            int max = array[0]; 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i]; 
                }
            }
            return max;
        }

        public static int FindMinArrayUnitIndex(int[] array)
        {
            int min = array[0]; // Задаем переменную для минимального элемента, приравниваем ее к первому элементу массива
            int index = 0; // Задаем переменную для индекса минимального элемента, приравниваем ее к первому элементу массива

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i]; // если значение по какому-л индексу оказалось меньше min, то присваеваем min это значение
                    index = i;
                }
            }
            return index;
        }

        public static int FindMaxArrayUnitIndex(int[] array)
        {
            int max = array[0]; 
            int index = 0; 

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i]; 
                    index = i;
                }
            }
            return index;
        }

        public static int FindSumOfOddIndexArrayElements(int[] array)
        {
            int sum = array[1]; // Задаем переменную суммы, приравниваем ее к первому элементу массива c нечетным индексом

            for (int i = 3; i < array.Length; i++) // начинаем счетчик с 3, потому что 1 нечетный уже учтен в sum 
            {
                if (i % 2 == 1)
                {
                    sum = sum + array[i]; // если индекс нечетный, то добавляем значение его элемента в сумму 
                }
            }
            return sum;
        }

        public static int [] ReverseArray(int[] array1)
        {
            int[] array2 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array2[array2.Length - 1 - i] = array1[i]; // Заполняем второй массив начиная с последнего индекса элементами из первого массива
            }
            return array2;
        }

        public static int FindOddArrayElementsNumber(int[] array)
        {
            int count = 0; // Задаем переменную количества

            for (int i = 0; i < array.Length; i++) // 
            {
                if (array[i] % 2 != 0) // если значение элемента в массиве нечетное, то увеличиваем счетчик количества
                {
                    count++;
                }
            }
            return count;
        }

        public static int[] ReverseArrayHalfs(int[] array1)
        {
            int[] array2 = new int[array1.Length];
            if (array1.Length % 2 != 0) // Если длинна массива нечетная

            {
                for (int i = 0; i < array1.Length / 2; i++)
                {
                    array2[i] = array1[array1.Length / 2 + 1 + i];
                    array2[array1.Length / 2 + i] = array1[i];
                }
                array2[array1.Length - 1] = array1[array1.Length / 2];
            }
            else // Если длинна массива четная
            {
                for (int i = 0; i < array1.Length / 2; i++)
                {
                    array2[i] = array1[array1.Length / 2 + i];
                    array2[array1.Length / 2 + i] = array1[i];
                }
            }
            return array2;
        }

        public static int[] MakeNewArraySortedAscendingBySelectSortFromArray1(int[] array1)
        {
            int[] array2 = new int[array1.Length];
            array2 = array1;

            for (int i = 0; i < array2.Length - 1; i++) // Для каждого индекса по счетчику..
            {
                int minIndex = i;

                for (int j = i; j < array2.Length; j++) // Производим сравнение элемента по внешнему счетчику со элементом по внутреннему
                {
                    if (array2[j] < array2[minIndex]) // Если найден элемент меньше, то присваиваем minIndex значение текущего счетчика
                    {
                        minIndex = j;
                    }
                }

                // После нахождения индекса минимального значения, меняем местами значения найденого индекса с индексом текущего счетчика
                int tmp = array2[i];
                array2[i] = array2[minIndex];
                array2[minIndex] = tmp;
            }
            return array2;
        }

        public static int[] MakeNewArraySortedDescendingByBubbleSortFromArray1(int[] array1)
        {
            int[] array2 = new int[array1.Length];
            array2 = array1;
            int temp;

            for (int i = 0; i < array2.Length - 1; i++) // Для каждого индекса по внешнему счетчику c 0 до предпоследнего элемента
            {
                for (int j = i+1; j < array2.Length; j++) // Перебираем элементы по внутреннему счетчику начиная с 0+1 элемента
                {
                    if (array2[i] < array2[j]) // Если найден элемент меньше, то меняем местами индексы
                    {
                        temp = array2[i];
                        array2[i] = array2[j];
                        array2[j] = temp;
                    }
                }
            }
            return array2;
        }
    }
}
