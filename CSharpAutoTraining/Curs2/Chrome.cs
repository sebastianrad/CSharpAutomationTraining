using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class Chrome
    {
        //variabile
        public int WindowWidth_int = 2000;
        public string WindowWidth_string;
        public double WindowWidth_double;

        //methode
        public void DisplayWindowWidth_int ()
        {
           
            if(WindowWidth_int > 1920)
            {
                Console.WriteLine("Window width more than 1920");
            }
            else
            {
                Console.WriteLine("window width less than 1920");
            }
        }  
    }
}
