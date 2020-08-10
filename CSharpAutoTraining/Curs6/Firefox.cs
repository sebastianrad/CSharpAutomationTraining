using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class Firefox
    {
        //local variable
        int WindowWidth=10;


        public Firefox()
        {
            //Firefox: called method with no arguments
        }

        public Firefox(int val)
        {
            //Firefox: called method with int as arg
            WindowWidth = val;
        }

        public Firefox(double val)
        {
            //Firefox: called method with double as arg
            WindowWidth = Convert.ToInt32(val);
        }

        public int GetWindowWidth()
        {
            Console.WriteLine("Firefox: return int; WindowWidth = " + WindowWidth);
            return WindowWidth;
        }
    }
}
