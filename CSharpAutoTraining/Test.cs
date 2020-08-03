using CSharpAutoTraining.Curs1;
using CSharpAutoTraining.Curs2;
using CSharpAutoTraining.Curs3;
using CSharpAutoTraining.Curs4;
using System;
using Browser = CSharpAutoTraining.Curs2.Browser;
using Chrome = CSharpAutoTraining.Curs3.Chrome;
using Firefox = CSharpAutoTraining.Curs3.Firefox;

namespace CursCSharp 
{
    class Program
    {
        static void Main(string[] args)
        {

            /*******************************/
            /* Curs4 - cod Practice / Tema */
            Console.WriteLine("----- CURS4 -----");
            // create objects

            CSharpAutoTraining.Curs4.Firefox firefox_curs4 = new CSharpAutoTraining.Curs4.Firefox();
            CSharpAutoTraining.Curs4.Skype skype_curs4 = new CSharpAutoTraining.Curs4.Skype();

            Console.WriteLine("----- Firefox section -----");
            firefox_curs4.StartBrowser();
            firefox_curs4.About();
            firefox_curs4.Ping();

            Console.WriteLine();
            Console.WriteLine("----- Skype section -----");
            skype_curs4.About();
            skype_curs4.Ping();


            /*******************************/
            /* Curs3 - cod Practice / Tema */
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----- CURS3 -----");
            // create objects
            CSharpAutoTraining.Curs3.Browser browser_curs3 = new CSharpAutoTraining.Curs3.Browser();
            CSharpAutoTraining.Curs3.Firefox firefox_curs3 = new CSharpAutoTraining.Curs3.Firefox();
            CSharpAutoTraining.Curs3.Chrome chrome_curs3 = new CSharpAutoTraining.Curs3.Chrome();
            CSharpAutoTraining.Curs3.InternetExplorer InternetExplorer_curs3 = new CSharpAutoTraining.Curs3.InternetExplorer();
            CSharpAutoTraining.Curs3.Edge edge_curs3 = new Edge();

            Console.WriteLine("----- Browser section -----");
            browser_curs3.About();
            browser_curs3.ChangeWindowWidth(1000);

            Console.WriteLine();
            Console.WriteLine("----- Firefox section -----");
            firefox_curs3.SetProfile("Firefox_Curs3");

            Console.WriteLine();
            Console.WriteLine("----- Chrome section -----");
            chrome_curs3.ChangeWindowWidth("9000");

            Console.WriteLine();
            Console.WriteLine("----- InternetExplorer section -----");
            InternetExplorer_curs3.ChangeWindowWidth(9000);

            Console.WriteLine();
            Console.WriteLine("----- Edge section -----");
            edge_curs3.NewFeatureFunction();

            /*******************************/


            /*******************************/
            /* Curs2 - cod Practice / Tema */
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----- CURS2 -----");
            // create objects
            CSharpAutoTraining.Curs2.Browser browser = new CSharpAutoTraining.Curs2.Browser();
            CSharpAutoTraining.Curs2.Firefox firefox = new CSharpAutoTraining.Curs2.Firefox();
            CSharpAutoTraining.Curs2.Chrome chrome = new CSharpAutoTraining.Curs2.Chrome();
            CSharpAutoTraining.Curs2.InternetExplorer InternetExplorer = new CSharpAutoTraining.Curs2.InternetExplorer();


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
            /* Curs1 - cod prezentare */

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