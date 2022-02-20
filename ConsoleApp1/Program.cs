using ConsoleApp1.MainClasses;
using Microsoft.Win32;
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
                    case "2": GetBrowsersName(); break;
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
        private static void GetBrowsersName()
        {
            Console.Clear();
            string browsersRegistryKeyPath = @"SOFTWARE\WOW6432Node\Clients\StartMenuInternet";

            string shellCommandKeyPath = @"shell\open\command";

            using (RegistryKey browsersKey = Registry.LocalMachine.OpenSubKey(browsersRegistryKeyPath))
            {
                foreach (string browserKeyName in browsersKey.GetSubKeyNames())
                {
                    using (RegistryKey browserKey = browsersKey.OpenSubKey(browserKeyName))
                    {
                        string browserName = browserKey.GetValue(null).ToString();

                        using (RegistryKey shellCommandKey = browserKey.OpenSubKey(shellCommandKeyPath))
                        {
                            string browserPath = shellCommandKey.GetValue(null).ToString();

                            Console.WriteLine($"{browserName}: {browserPath}");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
        private static void PrintBrowsers()
        {
            
        }
    }
}
