using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class InternetExplorer
    {
        public int WindowWidth_int = 1820;
        public string WindowWidth_string = "35";
        public double WindowWidth_double = 115.6;
        public void displayWindowWidth()
        {
            if (WindowWidth_int > 1920)
            {
                int index = 0;
                while (index < 3)
                {
                    Console.WriteLine("Window width is displayed three times:" + WindowWidth_int);
                    index++;
                }
            }
            else if (WindowWidth_int < 1920)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Window width is displayed two times:" + WindowWidth_int);
                }
            }
        }
    }
}