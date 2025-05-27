using System;

namespace Zadanie8
{
    internal class Program
    {
        static void Main()
        {


            Console.WriteLine("Программа для расчёта суммы ряда J.");

            // Контроль ввода количества элементов ряда n
            
            int n = 0;
            while(true)
            {
                Console.WriteLine("Введите количество элементов ряда n (целое положительное число): ");
                if (int.TryParse(Console.ReadLine(), out n))

                    break;
                else
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз.");
            }



            // Контроль ввода переменных z, x и a
            double a = 0;
            while (true)
            {
                Console.WriteLine("Ввелите значение a (вещественное число, должно быть больше 0):");
                if (double.TryParse(Console.ReadLine(), out a))

                    break;
                else
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз.");
            }
            double z = 0;
            while (true)
            {
                Console.WriteLine("Ввелите значение z (вещественное число):");
                if (double.TryParse(Console.ReadLine(), out z))

                    break;
                else
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз.");
            }
            double x = 0;
            while (true)
            {
                Console.WriteLine("Ввелите значение x (вещественное число):");
                if (double.TryParse(Console.ReadLine(), out x))

                    break;
                else
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз.");
            }



            // Вычисление суммы ряда J
            double J = CalculateSeries(n, z, x, a);

            // Вывод результата
            Console.WriteLine($"\nРезультат вычисления J для {n} элементов: {J:F6}");
        }

        /// <summary>
        /// Метод для вычисления суммы ряда J
        /// </summary>
        /// <param name="n">Количество элементов ряда</param>
        /// <param name="z">Переменная z</param>
        /// <param name="x">Переменная x</param>
        /// <param name="a">Переменная a</param>
        /// <returns>Сумма ряда J</returns>
        
        {
            double J = 0; // Итоговая сумма ряда
            double xPower = 1; // x^i, обновляется на каждой итерации
            double aPower = a; // a^(i+1), обновляется на каждой итерации

            for (int i = 1; i <= n; i++)
            {
                // Коэффициент для текущего члена ряда
                double coefficient = 1.3 + (i * 0.2);

                // Числитель
                double numerator;
                if (i % 2 != 0) // Нечётный элемент ряда
                {
                    numerator = coefficient * z - Math.Sin(xPower);
                }
                else // Чётный элемент ряда
                {
                    numerator = coefficient * z + Math.Cos(xPower);
                }

                // Знаменатель
                double denominator = Math.Sqrt(xPower + aPower);

                // Добавление члена ряда в сумму
                J += numerator / denominator;

                // Обновление степеней для следующей итерации
                xPower *= x * x; // x^(2*i)
                aPower *= a;     // a^(i+2)
            }

            return J;
        }

        /// <summary>
        /// Метод для ввода целых чисел с проверкой
        /// </summary>
        static int GetValidIntInput(string message, Predicate<int> validation)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result) && validation(result))
                {
                    return result;
                }
                Console.WriteLine("Некорректный ввод. Попробуйте ещё раз.");
            }
        }

        static int GetValidIntInput(string message)
        {
            return GetValidIntInput(message, _ => true);
        }

        /// <summary>
        /// Метод для ввода вещественных чисел с проверкой
        /// </summary>
        static double GetValidDoubleInput(string message, Predicate<double> validation)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (double.TryParse(input, out double result) && validation(result))
                {
                    return result;
                }
                Console.WriteLine("Некорректный ввод. Попробуйте ещё раз.");
            }
        }

        static double GetValidDoubleInput(string message)
        {
            return GetValidDoubleInput(message, _ => true);
        }
    }
}