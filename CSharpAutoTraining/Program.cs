using CSharpAutoTraining.Curs1;
using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            var browser = new Browser();
            var newBrowser = new Browser();
            //  Console.WriteLine(browser.WindowWidth);
            //   Console.WriteLine(browser.WindowHeight);
            //    browser.ChangeWindowHeight(2300);

            // Displaying the width and the height of the browser
            int width = browser.DisplayWindowWidth();
            int height = browser.DisplayWindowHeight();
            Console.WriteLine(width);
            Console.WriteLine(height);

            //Changing Browser window heigth and width
            newBrowser.ChangeWindowHeight(1080);
            newBrowser.ChangeWindowWidth(1920);
            Console.WriteLine("The new window height is:" + newBrowser.WindowHeight);
            Console.WriteLine("The new window width is:" + newBrowser.WindowWidth);




            //    Console.WriteLine(browser.WindowHeight);
            // browser.ChangeWindowWidth(3400);
            // Console.WriteLine(browser.WindowWidth);
            // simple Hello World program in C#
            Console.WriteLine("Hello world");
            Console.ReadKey();
        }
    }
}