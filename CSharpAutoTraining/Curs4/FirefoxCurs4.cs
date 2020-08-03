using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Curs4
{
    class FirefoxCurs4 : BrowserCurs4, IComponent, INetwork
    {
        public void Ping()
        {
            Console.WriteLine("Ping responded properly for Firefox");
        }

        public override void StartBrowser()
        {
            Console.WriteLine("Firefox browser is open");
        }

        public void About()
        {
            Console.WriteLine("About: Firefox version is 79.0");
        }
    }
}
