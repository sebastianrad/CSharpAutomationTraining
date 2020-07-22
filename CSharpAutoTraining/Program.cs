using CSharpAutoTraining.Curs1;
using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            var browser = new Browser();

            Console.WriteLine(browser.WindowWith);
            browser.ChangeWindowWith(2000);

            Console.WriteLine(browser.WindowWith);

            // simple Hello World program in C#
            Console.WriteLine("Hello world");
            Console.ReadKey();
        }
    }
}