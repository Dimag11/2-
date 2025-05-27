using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;

namespace RealNumbersReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reals.txt");
            string[] menuOptions = { "Чтение файла", "Выход" };
            int selectedIndex = 0;
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.CursorLeft = Console.WindowWidth / 2 - menuOptions[i].Length / 2;
                    Console.CursorTop = Console.WindowHeight / 2 - menuOptions.Length + i * 2;
                    Console.WriteLine(menuOptions[i]);

                    Console.ResetColor();
                }

                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.DownArrow && selectedIndex < menuOptions.Length - 1)
                    selectedIndex++;
                if (key == ConsoleKey.UpArrow && selectedIndex > 0)
                    selectedIndex--;
                if (key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (selectedIndex)
                    {
                        case 0: 
                            ReadAndProcessFile(filePath);
                            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                            Console.ReadKey(true);
                            break;

                        case 1:
                            exit = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        static void ReadAndProcessFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                List<double> numbers = new List<double>();
                int i = 0;

                while (i <= content.Length - 8)
                {
                    string part = content.Substring(i, 8);
                    if (char.IsDigit(part[0]) && part[1] == '.' &&
                        char.IsDigit(part[2]) && char.IsDigit(part[3]) &&
                        char.IsDigit(part[4]) && char.IsDigit(part[5]) &&
                        char.IsDigit(part[6]) && char.IsDigit(part[7]))
                    {
                        if (double.TryParse(part, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                        {
                            numbers.Add(number);
                            i += 8;
                            continue;
                        }
                    }
                    i++;
                }

                Console.WriteLine("Найденные числа:");
                double sum = 0;
                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                    sum += number;
                }

                Console.WriteLine($"\nКоличество чисел: {numbers.Count}");
                Console.WriteLine($"Сумма чисел: {sum}");
            }
            else
            {
                Console.WriteLine("Файл reals.txt не найден.");
            }
        }
    }
}
