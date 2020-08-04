using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class ProgramCurs6
    {
        static void Main(string[] args)
        {
            int windowWidth;
            FirefoxCurs6_1 ff1 = new FirefoxCurs6_1();
            FirefoxCurs6_1 ff2 = new FirefoxCurs6_1(5362);
            FirefoxCurs6_1 ff3 = new FirefoxCurs6_1(4.67);

            windowWidth = ff1.GetWindowWidth();
            Console.WriteLine(windowWidth);
        }
    }
}
