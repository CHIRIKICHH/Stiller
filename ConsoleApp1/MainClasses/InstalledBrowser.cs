using ConsoleApp1.Browsers;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MainClasses
{
    class InstalledBrowser
    {
        public List<IBrowser> GetAllInstalledBrowsers()
        {
            
        }

        private string GetBrowsersName()
        {
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
        }
    }
}
