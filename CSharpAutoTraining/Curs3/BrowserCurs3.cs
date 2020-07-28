using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class BrowserCurs3
    {
        public int WindowWidth_int;
        public string WindowWidth_string;

        public virtual void ChangeWindowWidth(int val)
        {
           
            Console.WriteLine("Browser metoda ChangeWindowWidth");
        }

        public virtual void About()
        {
            Console.WriteLine("Acest mesaj se va afisa si din alte clase");
        }
       
    }
}
