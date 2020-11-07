using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForMethods
{
   public static class Cycles
    {
        public static int DoSqrtAB(int a, int b)
        {
            int s = 1;
            for (int i = 0; i < b; i = i + 1)
            {
                s = s * a; // умножаем s на а и значение записываем в S
            }
            return s;
        }

        public static int [] MakeArrayMOD_A_from1to1000Equals0(int a)
        {
            if (a==0)
            {
                throw new Exception("a cant be equal 0");
            }
            int n = 1000 / a; // Определяем размер конечного массива на вывод
            int[] array = new int[n];
            int c = 0;
            for (int i = 1; i <= 1000; i++) // Задаем счетчик с 1 до 1000 с шагом в 1
            {
                if (i % a == 0) // если остаток от деления отсутсвует, то записываем это значение в массив и сдвигаем индекс массива на 1
                {
                    array[c] = i;
                    c++;
                }
            }
            return array;
        }

        public static int FindPositiveNumberSquareA_lessA(int a)
        {
            int s = 0;

            for (int i = 1; i * i < a; i = i + 1) // Задаем счетчик с 0 до А с шагом в 1
            {
                s = s + 1; // Пока квадрат i меньше А увеличиваем значение S на 1
            }
            return s; // Выводим S
        }
        
        public static int FindMaxDivisorForAexceptA(int a)
        {
            int s = 0;
            for (int i = 1; i < a; i++) // Счетчик идет с  i до A
            {
                if (a % i == 0) // Пишем i в s если оно делит A без остатка, и продолжаем цикл наращивания i
                {
                    s = i; // последняя i записанная в s и будет искомым делителем
                }
            }
           return s;
        }

        public static int FindSumNumbersFrom_a_to_b_MOD7_Equals0(int a, int b)
        {
            int s = 0;  // задаем s вне циклов
            if (a > b) // если Б окажется меньше А, меняем их местами
            {
                int c = a;
                a = b;
                b = c;
            }
            for (int i = a; i < b; i = i + 1) // начинаем счетчик с А и увеличиваем до Б
            {
                if (i % 7 == 0) // Если делится на 7 без отстатка, добавляем значение i к значению s
                {
                    s = s + i;
                }
            }
            return s;
        }

        public static int FindFiboNnumbers(int n)
        {
            int a = 1; // первое число фибо
            int b = 1; // второе число фибо
            int sum = 0;
            int i = 0;

            while (i < n - 2) // первых два числа уже заданы единицами
            {
                sum = a + b; // считаем сумму 1 и 2 числа
                b = a; // 2 число становится первым 
                a = sum; // а вместо первого числа используем сумму 1+2 
                i = i + 1; // наращиваем счетчик и повторяем
            }
            return sum;
        }

        public static int FindMaxCommonDivisor(int a, int b)
        {
            int nod=1; // наибольший общий делитель

            while (a != b) // делаем расчет пока a != б
            {
                if (a > b)
                {
                    a = a - b; // из большего вычитаем меньшее пока они не сравняются
                    nod = a;
                }
                else
                {
                    b = b - a; // аналогично если б окажется больше а
                    nod = b;
                }
            }
            return nod;
        }

        public static long Find_N_From_Npow3(long a)
        {
            long leftBorder = 0; // Задаем левую границу от О
            long rightBorder = a; // Задаем правую границу числом введеным пользователем
            long centr = 0; // задаем точку деления

            while (centr * centr * centr != a)
            {
                centr = (leftBorder + rightBorder) / 2;
                if (centr * centr * centr > a) // Если точка деления в кубе больше а, то смещаем правую границу на центр и продолжаем  деление
                {
                    rightBorder = centr;
                }
                else // // Если точка деления в кубе меньше а, то смещаем левую границу на центр и продолжаем  деление
                {
                    leftBorder = centr;
                }
            }
            return centr;
        }

        public static int FindHowManyOddNumbersInA(int a)
        {
            int s;
            int odd = 0;
            while (a != 0)
            {
                s = a % 10; // Узнаем последнюю цифру числа, через остаток от деления на 10
                if (s % 2 == 1) // Найденную цифру проверяем на остаток от деления на 2. Если он есть, то цифра нечетная, тогда прибавляем единицу в счетчик 
                {
                    odd += 1;
                }
                a = a / 10; // Отсекаем от числа последнюю цифру через результат деления на 10 и повторяем цикл
            }
            return odd;
        }

        public static int ReverseA(int a)
        {
            int s;
            string str = "";
            while (a != 0)
            {
                s = a % 10; // Узнаем последнюю цифру числа, через остаток от деления на 10
                str += s;  // Записываем эту цифру в строку вывода
                a = a / 10; // Отсекаем от числа последнюю цифру через результат деления на 10 и повторяем цикл
            }
            int reverse = Convert.ToInt32(str); // преобразуем строку str в число
            return reverse;
        }

        public static int FindNumbers_From1toN_WhenSumEVENsMoreThenSumODDs(int n)
        {
            // Считываем ввод и задаем переменные для счетчиков вне цикла
            int s;
            int odd = 0;
            int even = 0;
            int count = 0;
            int tmp = n;

            for (int i = 1; i <= tmp; i++) // Прогоняем цикл сравнения для каждго числа в диапазоне
            {
                n = i;
                odd = 0; // Обнуляем счетчики четных и нечетных
                even = 0;
                while (n != 0) // Отсекаем от числа последнюю цифру и смотрим на нее 
                {
                    s = n % 10;
                    if (s % 2 == 1) // Если нечетное - увеличиваем счетчик нечетных
                    {
                        odd = odd + s;
                    }
                    else // Если четное - увеличиваем счетчик четных
                    {
                        even = even + s;
                    }
                    n = n / 10;
                }
                if (even > odd) // Если четных > нечетных, то увеличиваем счетчик таких ситуаций
                {
                    count = count + 1;
                }
            }
            return count;
        }

        public static bool AreNumbersHaveEqualDigits(int a,int b)
        {
            int s; // заводим временную переменную снаружи цикла
            int s2; // заводим временную переменную снаружи цикла
            bool check = false;
            if (a<0)
            {
                a *= -1;
            }
            if (b<0)
            {
                b *= -1;
            }
            do
            {
                s = a % 10; // Узнаем последнюю цифру 1 числа
                int c = b;
                do
                {
                    s2 = c % 10; // Аналогично узнаем последнюю цифру 2 числа
                    if (s2 == s) // Если цифра 1 и второго числа совпала, bool = true
                    {
                        check = true; 
                    }
                    c = c / 10; // Если с крайней цифрой 2 числа совпадения нет, повторяем цикл и узнаем остальные цифры 2 числа

                } while (c != 0); // Повторяем пока не проверим все цифры 2 числа

                a = a / 10; // Если совпадений с крайней цифрой 1 числа нет, то повторяем цикл и узнаем остальные цифры 1 числа

            } while (a != 0); // Повторяем пока не проверим все цифры 1 числа
            
            return check;
        }
    }
}
