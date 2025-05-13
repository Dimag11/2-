using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            while (true)
            {
                Console.Write("Введите количество строк (N, 1 < N <= 25): ");
                if (int.TryParse(Console.ReadLine(), out N) && N > 1 && N <= 25)
                    break;
                else
                    Console.WriteLine("Неверный ввод. Количество строк должно быть от 2 до 25.");
            }

            while (true)
            {
                Console.Write("Введите количество столбцов (M, 1 < M <= 30): ");
                if (int.TryParse(Console.ReadLine(), out M) && M > 1 && M <= 30)
                    break;
                else
                    Console.WriteLine("Неверный ввод. Количество столбцов должно быть от 2 до 30.");
            }


            int[,] matrix = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int value;
                    while (true)
                    {
                        Console.Write($"Введите {i + 1}-й элемент {j + 1} строки массива: ");
                        if (int.TryParse(Console.ReadLine(), out value))
                            break;
                        else
                            Console.WriteLine("Значение должно быть числом.");
                    }
                    matrix[i, j] = value;
                }
            }
            Console.Clear();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine($"{i + 1}-й элемент {j + 1}-й строки: {matrix[i, j]}");
                    Console.ReadKey(true);
                }
            }

            HashSet<int> uniqueElements = new HashSet<int>();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    uniqueElements.Add(matrix[i, j]);
                }
            }

            Console.WriteLine($"Количество уникальных элементов в матрице: {uniqueElements.Count}");
            Console.ReadKey(true);
        }
    }
}
