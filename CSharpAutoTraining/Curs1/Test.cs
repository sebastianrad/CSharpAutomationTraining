using CSharpAutoTraining.Curs2;
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
            //Browser browser = new Browser();
            //browser.ChangeWindowHeight(1080);
            //browser.ChangeWindowWidth(1920);
            //browser.DisplayWindowHeight();
            //browser.DisplayWindowWidth();

            Curs2.Browser browser = new Curs2.Browser();
            Firefox firefox = new Firefox();
            Chrome chrome = new Chrome();
            IE ie = new IE();

            firefox.WindowWidth_int = 1920;
            firefox.WindowWidth_double = 1920.0;
            firefox.WindowWidth_string = "1920";

            Console.WriteLine(Convert.ToString(firefox.WindowWidth_int));
            Console.WriteLine(Convert.ToDouble(firefox.WindowWidth_string));
            Console.WriteLine(Convert.ToInt32(firefox.WindowWidth_double));

            chrome.displayWindowWidth(1024);

            ie.displayWindowWidth(1000);


        }
    }
}
