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
            var browser = new Browser();

            Console.WriteLine(browser.WindowWidth);
            browser.ChangeWindowWidth(1920);

            //Console.WriteLine(browser.WindowWith);


            Console.WriteLine(browser.WindowHeight);
            browser.ChangeWindowHeight(1080);

            //Console.WriteLine(browser.Height);

            Console.ReadKey();
        }
    }
}
