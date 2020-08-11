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
                if (value < 1024)
                {
                    Console.WriteLine("Rezolutia este prea mica");
                }
                else if (value > 1920)
                {
                    Console.WriteLine("Rezolutia este prea mare");
                }
                else
                {
                    WindowWidth = value;
                    Console.WriteLine("Rezolutia este:" + WindowWidth);
                }
            }
        }
    }
}
