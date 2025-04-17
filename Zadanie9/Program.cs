using System;

namespace Zadanie9
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            // Ввод длины массива
            Console.Write("Введите длину массива n: ");
            int n = int.Parse(Console.ReadLine());

            // Ввод элементов массива
            double[] array = new double[n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = double.Parse(Console.ReadLine());
            }

            // Подсчет нечетных чисел
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 != 0)
                {
                    a++;
                }
            }

            // Создание массива нечетных чисел
            double[] b = new double[a];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 != 0)
                {
                    b[index] = array[i];
                    index++;
                }
            }

            // Проверка на наличие нечетных чисел
            if (b.Length == 0)
            {
                Console.WriteLine("\nВ массиве нет нечётных чисел.");
            }
            else
            {
                // Сортировка пузырьком
                for (int i = 0; i < b.Length - 1; i++)
                {
                    for (int j = 0; j < b.Length - i - 1; j++)
                    {
                        if (b[j] > b[j + 1])
                        {
                            // Обмен элементов
                            double temp = b[j];
                            b[j] = b[j + 1];
                            b[j + 1] = temp;
                        }
                    }
                }

                // Вывод отсортированного массива
                Console.WriteLine("\nМассив из нечётных чисел, отсортированный по возрастанию:");
                foreach (var num in b)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
