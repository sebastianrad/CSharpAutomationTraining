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

        public Browser()
        {

        }

        public Browser(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }


        public void ChangeWindowWidth(int newWindowWidht)
        {
            WindowWidth = newWindowWidht;
        }
    }
}
