using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Browsers
{
    class GoogleChrome : IBrowser
    {
        private readonly string name = "GoogleChrome";
        private string path = String.Empty;
        private string cookieFilePath = String.Empty;
        private string loginsFilePath = String.Empty;

        public string Name { get { return name; } }

        public string GetAutoFills()
        {
            throw new NotImplementedException();
        }

        //return json format cookies
        public string GetCookies()
        {
            throw new NotImplementedException();
        }

        public string GetCreditCards()
        {
            throw new NotImplementedException();
        }

        public string GetPassword()
        {
            throw new NotImplementedException();
        }
    }
}
