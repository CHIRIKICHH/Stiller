using ConsoleApp1.MainClasses;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выбор:\n1 - Получить Куки\n2 - Получить пароли\n3 - Получить автозаполнение\n");
                Console.SetCursorPosition(7,0);
                switch (Console.ReadLine())
                {
                    case "1": GetCookies(); break;
                    case "2":break;
                    case "3":break;
                }
            }
        }

        private static void GetCookies()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите браузер:");
                PrintBrowsers();

            }
        }

        private static void PrintBrowsers()
        {
            InstalledBrowser.Test();
        }
    }
}
