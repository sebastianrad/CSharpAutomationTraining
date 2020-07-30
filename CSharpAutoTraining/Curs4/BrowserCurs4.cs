using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
	public abstract class BrowserCurs4
	{
		private int windowWidth;
		public int WindowWidth
		{
            get { return windowWidth; }

            set
            {
                if (value < 1024)
                {
                    Console.WriteLine("Resolution is smaller than 1024");
                }
                else if (value > 1920)
                {
                    Console.WriteLine("Resolution is bigger than 1920");
                }
                else
                {
                    windowWidth = value;
                }
            }

        }


		public abstract void StartBrowser();
	}
}
