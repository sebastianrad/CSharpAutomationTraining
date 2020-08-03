using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Curs3
{
    class IECurs3 : BrowserCurs3
    {
        public override void ChangeWindowWidth(int val)
        {
            WindowWidth_int = 1024;
            Console.WriteLine("WindowWidth_int  = " + WindowWidth_int);
        }
    }
}
