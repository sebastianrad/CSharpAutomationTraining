using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    public abstract class Browser
    {
        // variables
        private int windowWidth;


        public int WindowWidth
        {
            get 
            { 
                // returng the current value of windowWidth
                return windowWidth;  
            }

            set
            {
                // set a new value for windowWidthe such that it is bigger than 1024 but smaller than 1920

                // first check if the value is smaller than 1024
                if ( value < 1024 )
                {
                    // if smaller than 1024, write the corresponding error message
                    Console.WriteLine("WindowWidth: Enter a value bigger than 1024.");
                }

                // if value is bigger than 1024, check if it is below 1920 or bigger than 1920
                else
                {

                    // second check if the value is bigger than 1920
                    if (value > 1920)
                    {
                        // if bigger than 1920, write the corresponding error message
                        Console.WriteLine("WindowWidth: Enter a value smaller than 1920");
                    }

                    // if value is bigger than 1024 but smaller than 1920 => value is ok
                    else
                    {
                        // set the windowWidth to the new value
                        windowWidth = value;
                    }
                }
            }
        }

        public abstract void StartBrowser();

    }
}
