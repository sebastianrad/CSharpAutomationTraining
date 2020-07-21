using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class Test
    {
        static void Main(string[] args)
        {
            //create a browser object
            var browser = new Browser();

            //change Window Height using method from Browser class
            browser.ChangeWindowHeight(1080);

            //change Window Width using method from Browser class
            browser.ChangeWindowWidth(1920);

            //display Window Height using method from Browser class
            browser.DisplayWindowHeight();

            //display Window Width using method from Browser class
            browser.DisplayWindowWidth();

            Console.ReadKey();

        }


    }
}
