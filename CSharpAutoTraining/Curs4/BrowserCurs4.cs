using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    public abstract class BrowserCurs4
    {
        private int windowWidth;
        public int WindowWidth
        {

            get
            {
                return windowWidth;
            }

            set
            {
                if (value < 1024)
                {
                    Console.WriteLine("Less value");
                }
                else if (value > 1920)
                {
                    Console.WriteLine("Bigger value");
                }
                else
                {
                    windowWidth = value;
                    Console.WriteLine("This is: " + WindowWidth);
                }
            }
        }

        public abstract void StartBrowser();
    }

}


