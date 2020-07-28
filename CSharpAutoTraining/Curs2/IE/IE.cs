using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2.IE
{
    class IE : Browser
    {
        public void GetWindowWidth()
        {
            if (this.WindowWidth_int > 1920)
                WhileLoop();
            else
                ForLoop();
        }

        private void WhileLoop()
        {
            var index = 0;
            Console.WriteLine("\n");
            Console.WriteLine("Exercise 3");
            while (index < 3)
            {
                Console.WriteLine("Wile loop: " + this.WindowWidth_int);
                index++; //index = index + 1; se incrementeaza valoarea indexului pentru fiecare parcurgere de structura while (){} 
            }
        }

        private void ForLoop()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Exercise 3");
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine("For loop: " + this.WindowWidth_int);
            }
        }
    }
}
