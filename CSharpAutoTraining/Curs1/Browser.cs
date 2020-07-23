using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    public class Browser
    {

        //variable
        public int WindowWidth = 1024;
        public int WindowHeight = 720;

        public Browser()
        {

        }



        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;

            Console.WriteLine(WindowWidth);
        }

        public void ChangeWindowHeight(int newWindowHeight)
        {
            WindowWidth = newWindowHeight;

            Console.WriteLine(WindowHeight);
        }
    }
}
