using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    public class FirefoxCurs6
    {
        // variables
        int WindowWidth;

        public FirefoxCurs6()
        {
            Console.WriteLine("No argument constructor in Firefox");
        }

        public FirefoxCurs6(int val)
        {
            this.WindowWidth = val;
        }

        public FirefoxCurs6(double val)
        {
            this.WindowWidth = (int)val;
        }

        public int GetWindowWidth()
        {

            return WindowWidth;
        }



    }
}
