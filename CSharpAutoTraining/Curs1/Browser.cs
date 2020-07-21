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
        public int WindowWidth = 1024;
        public int WindowHeight = 800;
        public Browser()
        {

        }

        public Browser (int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }
        
        public void ChangeWindowWidth(int NewWindowWidth)
        {
            WindowWidth = NewWindowWidth;
        }

        public void ChangeWindowHeight(int NewWindowHeight)
        {
            WindowHeight = NewWindowHeight;
        }

        //method to display WindowHeight
        public void DisplayWindowHeight ()
        {
            Console.WriteLine(WindowHeight);
        }

        //method to display WindowWidth
        public void DisplayWindowWidth ()
        {
            Console.WriteLine(WindowWidth);
        }
    }
}
