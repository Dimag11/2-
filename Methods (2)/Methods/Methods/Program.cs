using System;
namespace Methods
{
    internal class Program
    {
        static int _jFibonacciProcess(int m)
        {
            int a = 0, b = 1;
            int totalDigitSum = 0;

            Console.WriteLine("Последовательность Фибоначи:");
            for (int i = 1; i <= m; i++)
            {
                int fib;
                if (i == 1)
                {
                    fib = 1;
                }
                else
                {
                    fib = a + b;
                    a = b;
                    b = fib;
                }

                Console.WriteLine($"F({i}) = {fib}");

                int temp = fib;
                while (temp != 0)
                {
                    totalDigitSum += temp % 10;
                    temp /= 10;
                }
            }

            return totalDigitSum;
        }

        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Введите число (или 'exit' для выхода): ");
                string inputStr = Console.ReadLine();

                if (inputStr.ToLower() == "exit")
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }

                if (int.TryParse(inputStr, out int input) && input > 0)
                {
                    int sum = _jFibonacciProcess(input);// Метод расчёта последовательности Фибоначи
                    Console.WriteLine($"Сумма цифр = {sum}");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Введите положительное целое число или 'exit'.");
                }
                Console.WriteLine();
            }

        }
    }
}
