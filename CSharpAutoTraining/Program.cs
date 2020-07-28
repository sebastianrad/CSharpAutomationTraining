using System;
using CSharpAutoTraining.Curs1;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            var browser = new Browser();
            Console.WriteLine(Console.WindowWidth);
            browser.ChangeWindowWidth(2000);

            Console.WriteLine(browser.WindowWidth);

            // simple Hello World program in C#
            Console.WriteLine("Hello world");
            Console.ReadKey();
        }
    }
}