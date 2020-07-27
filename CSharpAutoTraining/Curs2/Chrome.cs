using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class Chrome
    {
        // variables
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;



        // add method to change WindowWidth
        public void Change_WindowWidth(int newWindowWidth)
        {
            WindowWidth_int = newWindowWidth;
        }

        // add method to display window with depending on condition > 1920
        public void Check_WindowWidth_1920() 
        {
            if (WindowWidth_int > 1920)
            {
                Console.Write("Chrome WindowWidth_int = ");
                Console.WriteLine(WindowWidth_int);
            }
            else
            {
                Console.WriteLine("Chrome WindowWidth_int is less than 1920 ");
            }
        }
    }
}
