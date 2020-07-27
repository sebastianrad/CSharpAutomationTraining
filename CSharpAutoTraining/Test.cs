using CSharpAutoTraining.Curs1;
using CSharpAutoTraining.Curs2;
using CSharpAutoTraining.Curs3;
using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            var browser = new Browser();
            var firefox = new CSharpAutoTraining.Curs2.Firefox();
            var chrome = new Chrome();
            var IE = new InternetExplorer();

            //practice Curs2
            Console.WriteLine(Convert.ToString(firefox.WindowWidth_int));
            Console.WriteLine(Convert.ToDouble(firefox.WindowWidth_string));
            Console.WriteLine(Convert.ToInt32(firefox.WindowWidth_double));

            chrome.displayWidth();
            IE.displayWindowWidth();

            var newBrowser = new Browser();
            //  Console.WriteLine(browser.WindowWidth);
            //   Console.WriteLine(browser.WindowHeight);
            //    browser.ChangeWindowHeight(2300);

            // Displaying the width and the height of the browser
            int width = browser.DisplayWindowWidth();
            int height = browser.DisplayWindowHeight();
           // Console.WriteLine(width);
          //  Console.WriteLine(height);

            //Changing Browser window heigth and width
            newBrowser.ChangeWindowHeight(1080);
            newBrowser.ChangeWindowWidth(1920);
            Console.WriteLine("The new window height is:" + newBrowser.WindowHeight);
            Console.WriteLine("The new window width is:" + newBrowser.WindowWidth);

            //mostenire
            Browser myBrowser = new Browser();
            CSharpAutoTraining.Curs3.Firefox ff = new CSharpAutoTraining.Curs3.Firefox();
            ff.ChangeWindowHeight(1);

            IE ie = new IE();
            ie.ChangeWindowWidth(1000);

            // simple Hello World program in C#
            Console.WriteLine("Hello world");
            Console.ReadKey();
        }
    }
}