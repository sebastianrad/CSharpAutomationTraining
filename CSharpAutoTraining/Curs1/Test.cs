using CSharpAutoTraining.Curs2;
using CSharpAutoTraining.Curs3;
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
            /* var browser = new Browser();

             Console.WriteLine(browser.WindowWidth);
             browser.ChangeWindowWidth(1920);

             //Console.WriteLine(browser.WindowWith);


             Console.WriteLine(browser.WindowHeight);
             browser.ChangeWindowHeight(1080);

             //Console.WriteLine(browser.Height);

             */

            //Curs 2

            Browser browser = new Browser();

            Firefox ff = new Firefox();

            {
                int value1 = 10;
                string value2 = "11.123";
                double value3 = 12.3;

                var ConvertToString = Convert.ToString(value1);
                Console.WriteLine("Conversion to string " + ConvertToString + " is of type " + ConvertToString.GetType());

                var ConvertToDouble = Convert.ToDouble(value2);
                Console.WriteLine("Conversion to double " + ConvertToDouble + " is of type " + ConvertToDouble.GetType());

                var ConvertToInt = Convert.ToInt32(value3);
                Console.WriteLine("Conversion to int " + ConvertToInt + " is of type " + ConvertToInt.GetType());
            }

            Chrome chrome = new Chrome();
            {
                Console.WriteLine(chrome.WindowWidth_int);
                chrome.DisplayWindowWidth_int();

            }

            InternetExplorer ie = new InternetExplorer();
            {
                Console.WriteLine(ie.WindowWidth_int);
                ie.CheckWindowWidth_int();
            }

            int a = 5;
            string b;
            b = Convert.ToString(a);
            Console.WriteLine(b);



            //curs 3

            FirefoxCurs3 ff3 = new FirefoxCurs3();
            ff3.SetProfile("test");
            ff3.About();

            ChromeCurs3 chrome3 = new ChromeCurs3();
            chrome3.About();
            chrome3.ChangeWindowWidth(3);
           // Console.WriteLine("new val from chrome" + chrome3.WindowWidth_int);

            InternetExplorerCurs3 ie3 = new InternetExplorerCurs3();
            ie3.ChangeWindowWidth(500);
            ie3.About();
            


            EdgeCurs3 edge3 = new EdgeCurs3();
            edge3.About();
            edge3.ChangeWindowWidth(200);
            edge3.NewFeatureFunction();

            BrowserCurs3 browser3 = new BrowserCurs3();
            browser3.ChangeWindowWidth(1);
            browser3.About();







            Console.ReadKey();
        }
    }
}
