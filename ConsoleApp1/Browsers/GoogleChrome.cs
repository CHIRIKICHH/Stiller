using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Browsers
{
    class GoogleChrome : IBrowser
    {
        private string name;
        private string path;

        public override string BrowserName { get { return name;} }
        public override string BrowserPath { get { return path;} }

        public override string GetAutoFills()
        {
            throw new NotImplementedException();
        }

        public override string GetCookies()
        {
            throw new NotImplementedException();
        }

        public override string GetCreditCards()
        {
            throw new NotImplementedException();
        }

        public override string GetPassword()
        {
            throw new NotImplementedException();
        }
    }
}
