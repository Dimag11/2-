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

            do
            {
                Console.Write("Введите количество строк (N, 1 < N <= 25): ");
            } while (!int.TryParse(Console.ReadLine(), out N) || N <= 1 || N > 25);

            do
            {
                Console.Write("Введите количество столбцов (M, 1 < M <= 30): ");
            } while (!int.TryParse(Console.ReadLine(), out M) || M <= 1 || M > 30);
            

            int[,] matrix = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int value;
                    do
                    {
                        Console.Write($"Введите {j + 1}-й элемент {i + 1} строки массива: ");
                    } while (!int.TryParse(Console.ReadLine(), out value));

                    matrix[i, j] = value;
                }
            }
            Console.Clear();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine($"{j + 1}-й элемент {i + 1}-й строки: {matrix[i, j]}");
                    Console.ReadKey(true);
                }
            }


            List<int> uniqueElements = new List<int>();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int current = matrix[i, j];
                    bool isUnique = true;

                    foreach (int value in uniqueElements)
                    {
                        if (value == current)
                        {
                            isUnique = false;
                            break;
                        }
                    }

                    if (isUnique)
                    {
                        uniqueElements.Add(current);
                    }
                }
            }
            Console.WriteLine($"Количество уникальных элементов в матрице: {uniqueElements.Count}");
            Console.ReadKey(true);
        }
    }
}
