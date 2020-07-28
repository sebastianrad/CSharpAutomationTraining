using CSharpAutoTraining.Curs2;
using CSharpAutoTraining.Curs2.Chrome;
using CSharpAutoTraining.Curs2.Firefox;
using CSharpAutoTraining.Curs2.IE;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Curs2
{
    class BrowsersMain
    {
        static void Main(string[] args)
        {
            var browser = new Browser();
            var chrome = new Chrome();
            var firefox = new Firefox();
            var ie = new IE();

            firefox.WindowWidth_int = Convert.ToInt32(browser.WindowWidth_double);
            firefox.WindowWidth_string = browser.WindowWidth_int.ToString();
            firefox.WindowWidth_double = Double.Parse(browser.WindowWidth_string);
            Console.WriteLine("Exercise 1");
            Console.WriteLine("Double to int: " + firefox.WindowWidth_int);
            Console.WriteLine("Int to string: " + firefox.WindowWidth_string);
            Console.WriteLine("String to double: " + firefox.WindowWidth_double);

            chrome.DisplayWindowWidth();
            chrome.WindowWidth_int = 300000;
            chrome.DisplayWindowWidth();

            ie.GetWindowWidth();
            ie.WindowWidth_int = 300000;
            ie.GetWindowWidth();

            Console.WriteLine("\n");
            Console.Write("Press 'Enter' to exit... ");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                //run loop until Enter is press
            }
        }
    }

}
