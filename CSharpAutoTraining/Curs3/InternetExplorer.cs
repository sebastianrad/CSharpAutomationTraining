using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class InternetExplorer: Browser
    {

        public override void ChangeWindowWidth(int val)
        {
            WindowWidth_int = val / 2;
            Console.WriteLine("Override -> WindowWidth_int / 2 = " + WindowWidth_int);
        }

    }
}
