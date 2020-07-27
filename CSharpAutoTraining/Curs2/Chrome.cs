using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class Chrome
    {
        public int WindowWidth_int = 367;
        public string WindowWidth_string = "44";
        public double WindowWidth_double = 124.6;

        public void displayWidth()
        {
            if (WindowWidth_int > 1920)
            {
                Console.WriteLine(WindowWidth_int);
            }
            else
            {
                Console.WriteLine("Window width less than 1920");
            }
        }
    }
}
