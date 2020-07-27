using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class InternetExplorer
    {
        // variables
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        // loop index
        int i = 0;


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
                Console.WriteLine("Display 3 times window width, using while loop");

                while (i < 3)
                {
                    Console.Write("InternetExplorer WindowWidth_int = ");
                    Console.WriteLine(WindowWidth_int);
                    i++;
                }

            }
            else
            {
                Console.WriteLine("Display 2 times window width, using for loop");

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Chrome WindowWidth_int is less than 1920 ");
                }
            }
        }
    }
}
