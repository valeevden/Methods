using System;
using LibraryForMethods; //Подключаем библиотеку методов

namespace ProjectForTestMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вызываем методы по маске "Сущность методов(классов).Названия метода(параметры)"

            /* задача 1.1
             * SushnostClassov.PodschetUravnenia(4, 5);
             */


            /* Задача 1.2  
             * int a = 1;int b = 2; SushnostClassov.SwapParametrs(a, b); Console.WriteLine(a + " " + b);
             */

            /* задача 1.3
              int a = 14;
              int b = 3;
              int[] array=SushnostClassov.MakeDivisionAandModA(a, b);
              Console.WriteLine(array[0] + ", " + array[1]);
            */
            /* Задача 1.4
            int a = Convert.ToInt32(Console.ReadLine()); //reading "a" then convert to int
            int b = Convert.ToInt32(Console.ReadLine()); //reading "b" then convert to int
            int c = Convert.ToInt32(Console.ReadLine()); //reading "c" then convert to int
            double x=SushnostClassov.ReshaetUravnenie(a, b, c);
            Console.WriteLine("x=" + x); //display answer
            */
            //задача 1.5
            //double x1 = Convert.ToDouble(Console.ReadLine()); //reading "x1" then convert to double
            //double x2 = Convert.ToDouble(Console.ReadLine()); //reading "x2" then convert to double
            //double y1 = Convert.ToDouble(Console.ReadLine()); //reading "y1" then convert to double
            //double y2 = Convert.ToDouble(Console.ReadLine()); //reading "y2" then convert to double
            //Console.WriteLine(SushnostClassov.VivestiUravnenie(x1, x2, y1, y2));


            // задача 2.1
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Structure.ReshiAB(a, b);
            //Console.WriteLine("с="+c);

            //// задача 2.5
            //int a = Convert.ToInt32(Console.ReadLine());
            //string s = Structure.NapishiSlovamiVvod(a);
            //Console.WriteLine(s);

            // Задача 2.3
            //int a = Convert.ToInt32(Console.ReadLine()); 
            //int b = Convert.ToInt32(Console.ReadLine()); 
            //int c = Convert.ToInt32(Console.ReadLine());
            //int [] arrayABC = Structure.SortABCandMakeArrayABC(a, b, c);
            //HelpWithArray.DisplaySimpleArray(arrayABC);

            int[,] a = HelpWithArray.Make2DimensionalArray(4,7);
            HelpWithArray.Display2DimensionalArray(a);
            Console.WriteLine();
            Console.WriteLine();
            //int min = LibraryForMethods.Array2Dimensional.FindNumberMaxBetweenNeighborsElementInArray(a);
            int [,] lol = LibraryForMethods.Array2Dimensional.MakeNewTransposedArray(a);
            //HelpWithArray.DisplaySimpleArray(lol);
            //Console.WriteLine(min);
            HelpWithArray.Display2DimensionalArray(lol);

            // Задача 2.4
            //double a = Convert.ToDouble(Console.ReadLine()); 
            //double b = Convert.ToDouble(Console.ReadLine()); 
            //double c = Convert.ToDouble(Console.ReadLine());
            //double[] x = Structure.ReshaetKvadratnoeUravnenie(a, b, c);
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.Write(x[i] + " ");
            //}

            // Задача 2.2
            //int a = Convert.ToInt32(Console.ReadLine()); 
            //int b = Convert.ToInt32(Console.ReadLine());
            //int q = LibraryForMethods.Structure.FindCoordinateQuarter(a, b);
            //Console.WriteLine(q);
            // Задача 3.1
            //int a = Convert.ToInt32(Console.ReadLine()); 
            //int b = Convert.ToInt32(Console.ReadLine());
            //int s = LibraryForMethods.Cycles.DoSqrtAB(a, b);
            //Console.WriteLine(s);

            // Задача 3.2
            //int a = Convert.ToInt32(Console.ReadLine());
            //int[] ar = LibraryForMethods.Cycles.MakeArrayMOD_A_from1to1000Equals0(a);
            //LibraryForMethods.HelpWithArray.DisplaySimpleArray(ar);

            // Задача 3.3 и 3.4 и 3.5
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //bool s = LibraryForMethods.Cycles.AreNumbersHaveEqualDigits(a,b);
            //Console.WriteLine(s);

        }
    }
}
