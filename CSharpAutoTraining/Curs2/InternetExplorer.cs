using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class InternetExplorer
    {
        //variabile
        public int WindowWidth_int = 1500;
        public string WindowWidth_string;
        public double WindowWidth_double;

        //methode
        public void CheckWindowWidth_int()
        {
            Console.WriteLine("Curs 2 " + WindowWidth_int);
            //use a while to check if the window width is more than 1920
            if (WindowWidth_int > 1920)
            {
                int i = 0;

                while (i < 3)
                {
                    Console.WriteLine("Internet Explorer Window width is more 1920");
                    i++;
                }
            }
            else
            {
                //use a for to check if the window width is less than 1920
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Internet Explorer Window width is less then 1920");
                }
            }
        }
    }
}
