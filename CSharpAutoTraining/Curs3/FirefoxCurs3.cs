using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Curs3
{
    class FirefoxCurs3 : BrowserCurs3
    {
        public void SetProfile(string profileName)
        {

            Console.WriteLine("Profile Name = " + profileName);
        }
    }
}
