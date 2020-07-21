using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    public class Browser
    {
        //variables
        public int WindowHeight = 1024;
        public int WindowWidth = 2000;


        public Browser()
        {
           
        }

        public void ChangeWindowHeight(int newWindowHeight)
        {
            WindowHeight = newWindowHeight;
        }

        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }

        public void DisplayWindowHeight()
        {
            Console.WriteLine("browser's newHeight: " + WindowHeight);
        }

        public void DisplayWindowWidth()
        {
            Console.WriteLine("browser's newWidth: " + WindowWidth);
        }
    }
}
