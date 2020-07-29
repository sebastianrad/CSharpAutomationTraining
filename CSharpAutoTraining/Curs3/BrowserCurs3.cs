using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class BrowserCurs3
    {
        // variables
        public int WindowWidth_int;
        public string WindowWidth_string;

        public virtual void ChangeWindowWidth(int val)
        {
            WindowWidth_int = val;
            Console.WriteLine("WindowWidht_int = " + WindowWidth_int);
        }

        public virtual void About()
        {
            Console.WriteLine("About: BrowserCurs3");
        }
    }
}
