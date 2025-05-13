using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<clsRestaraunt> restaurants = new List<clsRestaraunt>();
            if (File.Exists("PopularRestaurants.txt"))
            {
                string[] lines = File.ReadAllLines("PopularRestaurants.txt", Encoding.GetEncoding("windows-1251"));
                foreach (string line in lines)
                {
                    restaurants.Add(new clsRestaraunt(line));
                }
            }
            else
            {
                Console.WriteLine("Файл PopularRestaurants.txt не найден.");
                return;
            }
            int SelectedIndex = 0;
            string[] menuPositions = { "Фильтр ресторанов по городу",
                "Фильтр ресторанов по указанному рейтингу",
                "Фильтр ресторанов по указанной кухне",
                "Принудительное присвоение конкретного значения рейтинга",
                "Расчёт длительности работы в часах",
                "Формирование полного адреса ресторана",
                "Сортировка ресторанов по рейтингу",
                "Формирование времени работы ресторана",
                "Выход" };
            bool flgMenu = false, flgRepeat = true;
            ConsoleKeyInfo key;

            while(flgRepeat)
            {
                while(!flgMenu)
                {
                    Console.Clear();
                    for(int i = 0; i < menuPositions.Length; i++)
                    {
                        if (SelectedIndex == i)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        Console.CursorLeft = Console.WindowWidth / 2 - menuPositions[i].Length /2;

                        Console.CursorTop = Console.WindowHeight / 2 - menuPositions.Length + i * 2;

                        Console.WriteLine(menuPositions[i]);

                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    key = Console.ReadKey(true);
                    if (key.Key.Equals(ConsoleKey.DownArrow) && SelectedIndex != menuPositions.Length - 1)
                        SelectedIndex++;
                    if (key.Key.Equals(ConsoleKey.UpArrow) && SelectedIndex != 0)
                        SelectedIndex--;
                    if (key.Key.Equals(ConsoleKey.Enter))
                        flgMenu = true;
                }
                Console.Clear();
                switch(SelectedIndex)
                {
                    case 0:
                        Console.Write("Введите город: ");
                        string cityInput = Console.ReadLine();
                        City city = (City)Enum.Parse(typeof(City), cityInput, true);
                        List<clsRestaraunt> result = clsRestaraunt.filtByCityName(restaurants, city);
                        foreach (var r in result)
                        {
                            Console.WriteLine(r.ToString());
                        }
                        break;
                    case 1:
                        Console.Write("Введите рейтинг: ");
                        byte raiting = byte.Parse(Console.ReadLine());
                        result = clsRestaraunt.filtByRate(restaurants, raiting);
                        foreach (var r in result)
                        {
                            Console.WriteLine(r.ToString());
                        }
                        flgMenu = false;
                        break;
                    case 2:
                        Console.Write("Введите кухню: ");
                        string cuisineInput = Console.ReadLine();
                        Cuisine cuisine = (Cuisine)Enum.Parse(typeof(Cuisine), cuisineInput, true);
                        result = clsRestaraunt.filtByCuisine(restaurants, cuisine);
                        foreach (var r in result)
                        {
                            Console.WriteLine(r.ToString());
                        }
                        flgMenu = false;
                        break;
                    case 3:
                        Console.Write("Введите ресторан: ");
                        string restaraunt = Console.ReadLine();
                        Console.Write("Введите рейтинг: ");
                        raiting = byte.Parse(Console.ReadLine());
                        foreach(var r in restaurants)
                        {
                            if(r.Name == restaraunt)
                            {
                                r.forceRateValue(raiting);
                                Console.WriteLine(r.ToString());
                                break;
                            }
                        }
                        flgMenu = false;
                        break;
                    case 4:
                        Console.Write("Введите ресторан: ");
                        restaraunt = Console.ReadLine();
                        foreach (var r in restaurants)
                        {
                            if (r.Name == restaraunt)
                            {
                                Console.WriteLine("Время работы: " + r.countWorkHours());
                                break;
                            }
                        }
                        flgMenu = false;
                        break;
                    case 5:
                        Console.Write("Введите ресторан: ");
                        restaraunt = Console.ReadLine();
                        foreach (var r in restaurants)
                        {
                            if (r.Name == restaraunt)
                            {
                                Console.WriteLine("Адрес: " + r.printAddress());
                                break;
                            }
                        }
                        flgMenu = false;
                        break;
                    case 6:
                        result = clsRestaraunt.sortByRate(restaurants);
                        foreach(var r in result)
                        {
                            Console.WriteLine(r.ToString());
                        }
                        flgMenu = false;
                        break;
                    case 7:
                        Console.Write("Введите ресторан: ");
                        restaraunt = Console.ReadLine();
                        foreach (var r in restaurants)
                        {
                            if (r.Name == restaraunt)
                            {
                                Console.WriteLine("Время работы: " + r.printTimeString());
                                break;
                            }
                        }
                        flgMenu = false;
                        break;
                    case 8:
                        flgRepeat = false;
                        break;
                }
                if (flgRepeat)
                {
                    key = Console.ReadKey(true);

                    if (key.KeyChar.Equals('q'))
                        flgRepeat = false;
                }
            }
        }
    }
    public enum City
    {
        Москва,
        СанктПетербург,
        Казань,
        Екатеринбург,
        Новосибирск
    }

    public enum Cuisine
    {
        Русская,
        Итальянская,
        Японская,
        Китайская,
        Французская,
        Индийская
    }
    public class clsRestaraunt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Rating { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public Cuisine Cuisine { get; set; }
        public string LocationNote { get; set; }
        public int OpenHour { get; set; }
        public int CloseHour { get; set; }

        public clsRestaraunt(string lineFromFile)
        {
            string[] parts = lineFromFile.Split(';');
            Id = int.Parse(parts[0]);
            Name = parts[1];
            Rating = byte.Parse(parts[2]);
            City = (City)Enum.Parse(typeof(City), parts[3]);
            Address = parts[4];
            Cuisine = (Cuisine)Enum.Parse(typeof(Cuisine), parts[5]);
            LocationNote = parts[6];
            OpenHour = int.Parse(parts[7]);
            CloseHour = int.Parse(parts[8]);
        }
        // Метод 1 – Фильтр по городу
        public static List<clsRestaraunt> filtByCityName(List<clsRestaraunt> restaurants, City city)
        {
            List<clsRestaraunt> result = new List<clsRestaraunt>();
            foreach (var r in restaurants)
            {
                if (r.City == city)
                    result.Add(r);
            }
            return result;
        }
        // Метод 2 – Фильтр по рейтингу
        public static List<clsRestaraunt> filtByRate(List<clsRestaraunt> restaurants, byte rate)
        {
            List<clsRestaraunt> result = new List<clsRestaraunt>();
            foreach (var r in restaurants)
            {
                if (r.Rating ==  rate)
                    result.Add(r);
            }
            return result;
        }
        // Метод 3 – Фильтр по кухне
        public static List<clsRestaraunt> filtByCuisine(List<clsRestaraunt> restaurants, Cuisine cuisine)
        {
            List<clsRestaraunt> result = new List<clsRestaraunt>();
            foreach (var r in restaurants)
            {
                if (r.Cuisine == cuisine)
                    result.Add(r);
            }
            return result;
        }
        // Метод 4 – Принудительное изменение рейтинга
        public void forceRateValue(byte newRating)
        {
            if (newRating >= 1 && newRating <= 5)
                Rating = newRating;
        }
        // Метод 5 – Расчёт количества рабочих часов
        public double countWorkHours()
        {
            if (CloseHour >= OpenHour)
                return CloseHour - OpenHour;
            else
                return 24 - OpenHour + CloseHour;
        }
        // Метод 7 – Сортировка по рейтингу (по убыванию)
        public static List<clsRestaraunt> sortByRate(List<clsRestaraunt> restaurants)
        {
            List<clsRestaraunt> sorted = new List<clsRestaraunt>(restaurants);
            for (int i = 0; i < sorted.Count - 1; i++)
            {
                for (int j = i + 1; j < sorted.Count; j++)
                {
                    if (sorted[j].Rating > sorted[i].Rating)
                    {
                        var temp = sorted[i];
                        sorted[i] = sorted[j];
                        sorted[j] = temp;
                    }
                }
            }
            return sorted;
        }
        public override string ToString()
        {
            string stars = new string('*', Rating);
            return $"{Id}. «{Name}» ({Cuisine.ToString().ToLower()} кухня); рейтинг: \"{stars}\"; адрес: {printAddress()}; время работы: {printTimeString()}";
        }
        public string printAddress()
        {
            return $"г. {City}, {Address} ({LocationNote})";
        }
        public string printTimeString()
        {
            return $"{OpenHour:00}:00 – {CloseHour:00}:00";
        }

    }
}
