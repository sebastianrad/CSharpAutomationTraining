using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class Browser
    {
        // variabila
        public int WindowWidth = 2000;
        public int WindowHeight = 1000;

        //method
        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;

            Console.WriteLine(WindowWidth);
        }
        //method
        public void ChangeWindowHeight(int newHeight)
        {
            WindowHeight = newHeight;
            Console.WriteLine(WindowHeight);
        }


        
    }
}
