using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshednevnik
{
    internal class Program
    {
        static DateTime date = DateTime.Now;
        static string data = date.ToShortDateString();
        static ConsoleKeyInfo clavisha = Console.ReadKey();
        static int position = 3;
        static void Main()
        {
            data = date.ToShortDateString();
            Strelki();
        }
        static void Strelki()
        {
            Console.WriteLine("Выбрана дата: " + data);
            Console.WriteLine("Для выхода введите \"Выход\" в самой нижней строчке");
            Console.WriteLine("---------------------------------------------------");
            PereclDat();
            while (true)
            {
                do
                {
                    string del = new string(' ', 2);
                    if (clavisha.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(0, position--);
                        if (position == 2)
                            position = 3;
                    }
                    else if (clavisha.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(0, position++);
                        if (position == 6)
                            position = 5;
                    }
                    Console.Write(del);
                    Console.SetCursorPosition(0, position);
                    Console.Write("->");
                    clavisha = Console.ReadKey();
                    if (clavisha.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Strelki();
                    }
                    if (clavisha.Key == ConsoleKey.LeftArrow)
                    {
                        IzmData();
                    }
                    if (clavisha.Key == ConsoleKey.RightArrow)
                    {
                        IzmData();
                    }
                    if (position == 5)
                    {
                        if (Console.ReadLine() == "Выход")
                        {
                            Environment.Exit(0);
                        }
                    }
                } while (clavisha.Key != ConsoleKey.Enter);
                PereclDat();
            }
        }
        static void PereclDat()
        {
            if (data == "06.11.2022")
            {
                Zametka1();
                if (clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (position)
                    {
                        case 3:
                            Opis1_1();
                            break;
                        case 4:
                            Opis1_2();
                            break;
                    }
                }
            }
            if (data == "07.11.2022")
            {
                Zametka2();
                if (clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (position)
                    {
                        case 3:
                            Opis2_1();
                            break;
                        case 4:
                            Opis2_2();
                            break;
                    }
                }
            }
            if (data == "08.11.2022")
            {
                Zametka3();
                if (clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (position)
                    {
                        case 3:
                            Opis3_1();
                            break;
                        case 4:
                            Opis3_2();
                            break;
                    }
                }
            }
            if (data == "09.11.2022")
            {
                Zametka4();
                if (clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (position)
                    {
                        case 3:
                            Opis4_1();
                            break;
                        case 4:
                            Opis4_2();
                            break;
                    }
                }
            }
            if (data == "10.11.2022")
            {
                Zametka5();
                if (clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (position)
                    {
                        case 3:
                            Opis5_1();
                            break;
                        case 4:
                            Opis5_2();
                            break;
                    }
                }
            }
        }
        static void IzmData()
        {

            if (clavisha.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                date = date.AddDays(-1);
                string data = date.ToShortDateString();
                Main();
            }
            if (clavisha.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
                date = date.AddDays(1);
                string data = date.ToShortDateString();
                Main();
            }
        }
        static void Zametka1()
        {
            List<string> zametka = new List<string>();
            zametka.Add("  1)Сделать проверочную по С#");
            zametka.Add("  2)Сходить в зал");
            foreach (string item in zametka)
                Console.WriteLine(item);
        }
        static void Opis1_1()
        {
            List<string> opisanie = new List<string>();
            opisanie.Add("Сделать проверочную по C#");
            opisanie.Add("--------------------------");
            opisanie.Add("  Описание: Написать код для проверочной");
            opisanie.Add("  Дата: " + data);
            foreach (string item in opisanie)
                Console.WriteLine(item);
        }
        static void Opis1_2()
        {
            List<string> opisanie = new List<string>();
            opisanie.Add("Сходить в зал");
            opisanie.Add("--------------------------");
            opisanie.Add("  Описание: Провести тренировку по программе");
            opisanie.Add("  Дата: " + data);
            foreach (string item in opisanie)
                Console.WriteLine(item);
        }
        static void Zametka2()
        {
            List<string> zametka = new List<string>();
            zametka.Add("  1)Подготовиться к практической по Психологии Общения");
            zametka.Add("  2)Переделать план эвакуации по БЖД");
            foreach (string item in zametka)
                Console.WriteLine(item);
        }
        static void Opis2_1()
        {
            Console.Clear();
            List<string> opisanie = new List<string>();
            opisanie.Add("Подготовиться к практической по Психологии Общения");
            opisanie.Add("--------------------------");
            opisanie.Add("  Описание: Подготовить сценку");
            opisanie.Add("  Дата: " + data);
            foreach (string item in opisanie)
                Console.WriteLine(item);
        }
        static void Opis2_2()
        {
            Console.Clear();
            List<string> opisanie = new List<string>();
            opisanie.Add("Переделать план эвакуации по БЖД");
            opisanie.Add("--------------------------");
            opisanie.Add("  Описание: Просмотреть план и изучить ошибки");
            opisanie.Add("  Дата: 26.10.2022 19:00");
            foreach (string item in opisanie)
                Console.WriteLine(item);
        }
        static void Opis3_1()
        {
            Console.Clear();
            List<string> opisanie = new List<string>();
            opisanie.Add("Прогулять философию");
            opisanie.Add("--------------------------");
            opisanie.Add("  Описание: Написать заявление от имени родителей");
            opisanie.Add("  Дата: " + data);
            foreach (string item in opisanie)
                Console.WriteLine(item);
        }
        static void Zametka3()
        {
            List<string> zametka = new List<string>();
            zametka.Add("  1)Прогулять философию");
            zametka.Add("  2)Подготовиться к практической по Python");
            foreach (string item in zametka)
                Console.WriteLine(item);
        }
        static void Opis3_2()
        {
            Console.Clear();
            List<string> opisanie = new List<string>();
            opisanie.Add("Подготовиться к практической по Python");
            opisanie.Add("--------------------------");
            opisanie.Add("  Описание: Повторить кортежи,множества");
            opisanie.Add("  Дата: " + data);
            foreach (string item in opisanie)
                Console.WriteLine(item);
        }
        static void Zametka4()
        {
            List<string> zametka = new List<string>();
            zametka.Add("  1)Поиграть в доту");
            zametka.Add("  2)Забрать заказ");
            foreach (string item in zametka)
                Console.WriteLine(item);
        }
        static void Opis4_1()
        {
            Console.Clear();
            List<string> opisanie = new List<string>();
            opisanie.Add("Поиграть в доту");
            opisanie.Add("--------------------------");
            opisanie.Add("  Описание: Сыграть в рейтинг");
            opisanie.Add("  Дата: " + data);
            foreach (string item in opisanie)
                Console.WriteLine(item);
        }
        static void Opis4_2()
        {
            Console.Clear();
            List<string> opisanie = new List<string>();
            opisanie.Add("Забрать заказ");
            opisanie.Add("--------------------------");
            opisanie.Add("  Описание: Сходить в постамат WildBerries");
            opisanie.Add("  Дата: " + data);
            foreach (string item in opisanie)
                Console.WriteLine(item);
        }
        static void Zametka5()
        {
            List<string> zametka = new List<string>();
            zametka.Add("  1)Погулять с друзьями");
            zametka.Add("  2)Получить аттестацию по КС");
            foreach (string item in zametka)
                Console.WriteLine(item);
        }
        static void Opis5_1()
        {
            Console.Clear();
            List<string> opisanie = new List<string>();
            opisanie.Add("Погулять с друзьями");
            opisanie.Add("--------------------------");
            opisanie.Add("  Описание: Сходить на выставку");
            opisanie.Add("  Дата: " + data);
            foreach (string item in opisanie)
                Console.WriteLine(item);
        }
        static void Opis5_2()
        {
            Console.Clear();
            List<string> opisanie = new List<string>();
            opisanie.Add("Получить аттестацию по КС");
            opisanie.Add("--------------------------");
            opisanie.Add("  Описание: Выполнить тест");
            opisanie.Add("  Дата: " + data);
            foreach (string item in opisanie)
                Console.WriteLine(item);
        }
    }
}
