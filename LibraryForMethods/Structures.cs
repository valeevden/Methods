using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForMethods
{
    public static class Structure // Сущность классов для всех методов
    {
        public static int SolveAB(int a, int b)
        {
            int c = 0;
            if (a == b)   // if a=b
            {
                c = a * b;
            }
            if (a > b) //if a>b
            {
                c = a + b;
            }
            if (a < b)  //if a<b
            {
                c = a - b;
            }
            return c;
        }

        public static string DisplayWordsForNumbers(int a)
        {
            int dozen = a / 10; // Определяем сколько в числе десяток
            int units = a % 10; // и сколько единиц
            string s="";

            switch (a) // "Преобразуем" числа с 10 до 19
            {
                case 10:
                    s+=("Десять");
                    break;
                case 11:
                    s+=("Одиннадцать");
                    break;
                case 12:
                    s+=("Двенадцать");
                    break;
                case 13:
                    s+=("Тринадцать");
                    break;
                case 14:
                    s+=("Четырнадцать");
                    break;
                case 15:
                    s+=("Пятнадцать");
                    break;
                case 16:
                    s+=("Шестнадцать");
                    break;
                case 17:
                    s+=("Семнадцать");
                    break;
                case 18:
                    s+=("Восемнадцать");
                    break;
                case 19:
                    s+=("Девятнадцать");
                    break;
            }
            if (a > 20) // Если число больше 20, то используем "сложение" десяток и единиц
            {
                switch (dozen) // "Преобразуем" десятки в текст и выводим
                {
                    case 2:
                        s+=("Двадцать");
                        break;
                    case 3:
                        s+=("Тридцать");
                        break;
                    case 4:
                        s+=("Сорок");
                        break;
                    case 5:
                        s+=("Пятьдесят");
                        break;
                    case 6:
                        s+=("Шестьдесят");
                        break;
                    case 7:
                        s+=("Семьдесят");
                        break;
                    case 8:
                        s+=("Восемьдесят");
                        break;
                    case 9:
                        s+=("Девяносто");
                        break;
                }

                switch (units) // "Преобразуем" единицы в текст и выводим в ту же линию, что и десятки
                {
                    case 0:
                        break;
                    case 1:
                        s+=(" Один");
                        break;
                    case 2:
                        s+=(" Два");
                        break;
                    case 3:
                        s+=(" Три");
                        break;
                    case 4:
                        s+=(" четыре");
                        break;
                    case 5:
                        s+=(" Пять");
                        break;
                    case 6:
                        s+=(" Шесть");
                        break;
                    case 7:
                        s+=(" Семь");
                        break;
                    case 8:
                        s+=(" Восемь");
                        break;
                    case 9:
                        s+=(" Девять");
                        break;
                }
            }

            return Convert.ToString(s);


        }

        public static int[] SortABCandMakeArrayABC(int a, int b, int c)
        {
            int[] array;

            if (a < b && a < c)
            {
                if (b < c)
                {
                    //Console.WriteLine($"{a}, {b}, {c}");
                    array = new int[3] {a, b, c};
                    return array;
                }
                else
                {
                    //Console.WriteLine($"{a}, {c}, {b}");
                    array = new int[3] {a, c, b};
                    return array;
                }
            }
            else if (b < a && b < c)
            {
                if (a < c)
                {
                    //Console.WriteLine($"{b}, {a}, {c}");
                    array = new int[3] {b, a, c};
                    return array;
                }
                else
                {
                   // Console.WriteLine($"{b}, {c}, {a}");
                    array = new int[3] {b, c, a};
                    return array;
                }
            }
            else if (a > b)
            {
                //Console.WriteLine($"{c}, {b}, {a}");
                    array = new int[3] {c, b, a};
                    return array;
            }
            else
            {
               // Console.WriteLine($"{c}, {a}, {b}");
                    array = new int[3] {c, a, b};
                    return array;
            }


        }

        public static double[] FindSolutionForQuadratEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("Parametr 'a' can't be 0");
            }
            double x1; // задаем переменные для корней
            double x2;

            double d = b * b - 4 * a * c; // Ищем дискриминант
            if (d < 0)
            {
                return new double [0]; // Корней нет если дискриминант отрицательный
            }
            else if (d == 0) // Для дискриминанта равного 0 - один корень
                {
                return new double[1] { -b / (2 * a) };
                }
                else // В остальных случаях два корня
                {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                return new double[2] { x1, x2 };
                }
         }

        public static int FindCoordinateQuarter(int x, int y)
        {
            int quarter=0;
            if (x > 0) // X positive
            {
                if (y > 0) // and Y positive
                {
                    quarter = 1;
                    return quarter;
                }
                else // if X pos and Y negative
                {
                    quarter = 4;
                   return quarter;
                }
            }
            else
                if (y < 0) // X neg and Y neg
            {
                    quarter = 3;
                return quarter;
            }
            else // X neg and Y pos
            {
                    quarter = 2;
                   return quarter;
            }
        }
    }
}
