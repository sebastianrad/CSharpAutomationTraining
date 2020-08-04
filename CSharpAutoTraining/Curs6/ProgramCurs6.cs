using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class ProgramCurs6
    {
        static void Main(string[] args)
        {
            FirefoxCurs6 ff1 = new FirefoxCurs6();
            FirefoxCurs6 ff2 = new FirefoxCurs6(1080);
            FirefoxCurs6 ff3 = new FirefoxCurs6(1024.0);

            //local variables
            int NewWindowWidth1 = ff2.GetWindowWidth();
            double NewWindowWidth2 = ff3.GetWindowWidth();



            Console.WriteLine("The new window width(int) is: " + NewWindowWidth1);
            Console.WriteLine("The new window width(double) is: " + NewWindowWidth2);
        }
    }
}
