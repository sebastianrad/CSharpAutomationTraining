using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class FF
    {
        public int WindowWidth = 1024;
        public int windowWidthSize
        {
            get { return WindowWidth; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Value is:" + WindowWidth);
                }
                else
                {
                    Console.WriteLine("Value is:" + 1920);
                }
            }
        }
    }
}
