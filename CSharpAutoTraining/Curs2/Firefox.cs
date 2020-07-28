using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class Firefox
    {
        //variabile
        public int WindowWidth_int = 10;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void NewDateForWindow(int newWindowWidth_int, string newWindowWidth_string, double newWindowWidth_double)
        {
            WindowWidth_int =  newWindowWidth_int;
             WindowWidth_string = newWindowWidth_string;
             WindowWidth_double = newWindowWidth_double;
        }

        public void NewDateForWindow2(int newWindowWidth_int)
        {
            WindowWidth_int = newWindowWidth_int;
            
        }

       
    }
}
