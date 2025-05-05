using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumeratedType
{
    [Flags]
    enum DayTime
    {
        Morning = 128,   // 1 << 7
        Noon = 256,   // 1 << 8
        Day = 512,   // 1 << 9
        Evening = 1024,  // 1 << 10
        Midnight = 2048,  // 1 << 11
        Night = 4096   // 1 << 12
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DayTime allTimes = DayTime.Morning | DayTime.Noon | DayTime.Day |
                          DayTime.Evening | DayTime.Midnight | DayTime.Night;

            // Перебираем от младших к старшим битам (от 128 до 4096)
            for (int bit = 128; bit <= 4096; bit <<= 1)
            {
                DayTime current = (DayTime)bit;

                if ((allTimes & current) != 0)
                {
                    switch (current)
                    {
                        case DayTime.Morning:
                            Console.WriteLine("Доброе утро!");
                            break;
                        case DayTime.Noon:
                            Console.WriteLine("Добрый полдень!");
                            break;
                        case DayTime.Day:
                            Console.WriteLine("Добрый день!");
                            break;
                        case DayTime.Evening:
                            Console.WriteLine("Добрый вечер!");
                            break;
                        case DayTime.Midnight:
                            Console.WriteLine("Доброй полночи!");
                            break;
                        case DayTime.Night:
                            Console.WriteLine("Спокойной ночи!");
                            break;
                        default:

                            break;
                    }
                }
            }
            Console.ReadKey(true);
        }
    }
}
