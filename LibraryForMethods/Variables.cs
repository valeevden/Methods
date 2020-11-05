using System;

namespace LibraryForMethods
{
    public static class Variable // Сущность классов для всех методов
    {
        public static double SolveTheEquation(int a, int b)
        {
            if (a==b)
            {
                throw new Exception("a can't be equal b");
            }
            double x = Convert.ToDouble(5 * a + b * b) / (b - a); // convert int to double and calculate
            return x;
        }

        public static void SwapParametrs(int a, int b)
        {
            int temp = a; //make temp for copy "a"
            a = b;
            b = temp;
        }
        public static int[] MakeDivisionAandModA(int a, int b)
        {
            int i = a / b;
            int j = a % b;
            int [] array = new int[] { i, j };
            return array;
        }
        public static double FindSolutionForEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new Exception("a can't be  0");
            }
            double x = Convert.ToDouble(c - b) / a; //convert "x" to double and calculate
            return x;
        }

        public static string DisplaySolutionForFunction(double x1, double x2, double y1, double y2)
        {
            double a = (y1 - y2) / (x2 - x1); // математика расчета а
            double b = (x1 * y2 - x2 * y1) / (x2 - x1); // математика расчета б
            string eq = Convert.ToString($"Y={a}X+{b}"); // Конвертируем  в стринг расчеты по формуле Y = AX + B
            return eq;
        }


    }
}
