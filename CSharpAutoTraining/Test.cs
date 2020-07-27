using CSharpAutoTraining.Curs1;
using CSharpAutoTraining.Curs2;
using System;
using Browser = CSharpAutoTraining.Curs2.Browser;

namespace CursCSharp 
{
    class Program
    {
        static void Main(string[] args)
        {

            /*******************************/
            /* Curs2 - cod Practice / Tema */

            // create objects
            CSharpAutoTraining.Curs2.Browser browser = new Browser();
            Firefox firefox = new Firefox();
            Chrome chrome = new Chrome();
            InternetExplorer InternetExplorer = new InternetExplorer();


            // For Firefox:
            Console.WriteLine("----- Firefox section -----");
            // set values for variables
            // convert from int->string, string->double, double->int
            // display in console the values
            firefox.WindowWidth_int = 123456;
            Console.Write("Firefox WindowWidth_int initial = ");
            Console.WriteLine(firefox.WindowWidth_int);

            firefox.WindowWidth_string = Convert.ToString(firefox.WindowWidth_int);
            Console.Write("Firefox WindowWidth_string = ");
            Console.WriteLine(firefox.WindowWidth_string);

            firefox.WindowWidth_double = Convert.ToDouble(firefox.WindowWidth_string);
            Console.Write("Firefox WindowWidth_double = ");
            Console.WriteLine(firefox.WindowWidth_double);

            firefox.WindowWidth_int = Convert.ToInt32(firefox.WindowWidth_double);
            Console.Write("Firefox WindowWidth_int after convert = ");
            Console.WriteLine(firefox.WindowWidth_int);


            // For Chrome:
            Console.WriteLine();
            Console.WriteLine("----- Chrome section -----");
            // set window width value = 2000
            // check window width value > 1920
            chrome.Change_WindowWidth(2000);
            chrome.Check_WindowWidth_1920();

            // set window width value = 1000
            // check window width value < 1920
            chrome.Change_WindowWidth(1000);
            chrome.Check_WindowWidth_1920();



            // For InternetExplorer:
            Console.WriteLine();
            Console.WriteLine("----- InternetExplorer section -----");
            // set window width value = 2000
            // check window width value > 1920
            InternetExplorer.Change_WindowWidth(2000);
            InternetExplorer.Check_WindowWidth_1920();

            // set window width value = 1000
            // check window width value < 1920
            InternetExplorer.Change_WindowWidth(1000);
            InternetExplorer.Check_WindowWidth_1920();


            Console.ReadKey();

            /*******************************/



            /*******************************/
            /* Curs1 - cod Practice / Tema */

            ////create a browser object
            //var browser = new Browser();

            ////change Window Height using method from Browser class
            //browser.ChangeWindowHeight(1080);

            ////change Window Width using method from Browser class
            //browser.ChangeWindowWidth(1920);

            ////display Window Height using method from Browser class
            //browser.DisplayWindowHeight();

            ////display Window Width using method from Browser class
            //browser.DisplayWindowWidth();

            //Console.ReadKey();

            /*******************************/


            /*******************************/
            /* Curs1 - code prezentare */

            //var browser = new Browser();

            ////display browser`s initial width - 1024
            //Console.WriteLine(browser.WindowWidth);
            //browser.ChangeWindowWidth(2000);

            ////display browser`s new width - 2000
            //Console.WriteLine(browser.WindowWidth);

            ////display browser`s initial height - 800
            //Console.WriteLine(browser.WindowHeight);

            ////display browser`s new height - 1300
            //browser.ChangeWindowHeight(1300);
            //Console.WriteLine(browser.WindowHeight);

            //// simple Hello World program in C#
            //Console.WriteLine("Hello world");
            //Console.ReadKey();

            /*******************************/
        }
    }
}