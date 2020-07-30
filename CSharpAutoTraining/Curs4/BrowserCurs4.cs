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
                    Console.WriteLine("Rezolutia este prea mica");
                }
                else if (value > 1920)
                {
                    Console.WriteLine("Rezolutia este prea mare");
                }
                else
                {
                    windowWidth = value;
                    Console.WriteLine("Rezoltia este: " + WindowWidth);
                }
            }
        }

         public abstract void StartBrowser();
    }
}
