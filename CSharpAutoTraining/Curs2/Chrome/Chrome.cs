using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2.Chrome
{
    class Chrome : Browser 
    {
        public void DisplayWindowWidth()
        {
            Console.WriteLine("\n");//adds a new row in console
            Console.WriteLine("Exercise 2");

            if (this.WindowWidth_int > 1920)
                Console.WriteLine(WindowWidth_int.ToString());
            else
                Console.WriteLine("Window width less than 1920");
        }
    }

   
}
