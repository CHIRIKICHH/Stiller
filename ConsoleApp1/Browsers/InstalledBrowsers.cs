using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Browsers
{
    class InstalledBrowsers
    {
        List<IBrowser> browsers;

        public InstalledBrowsers(params IBrowser[] findedBrowsers)
        {
            browsers = new List<IBrowser>();
            browsers.AddRange(findedBrowsers);
        }

        public IBrowser this[int index]
        {
            get => browsers[index];
        }

        public IBrowser this[string name]
        {
            get => browsers.Find(x => x.Name == name);
        }
    }
}
