using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
	class InternetExplorer
	{
		public int WindowWidth_int = 1919;
		public string WindowWidth_string;
		public double WindowWidth_double;

		//add a method to display 3 times window width if WindowWidth_int > 1920(use while) or 2 times if not(use for).
		public void DisplayMultipleTimes() 
		{
			if (WindowWidth_int > 1920)
			{
				int i = 0;
				while (i < 3)
				{
					Console.WriteLine("Internet Explorer Window width is more than 1920");
					i++;
				}
			}
			else 
			{
				for (int j = 0; j < 2; j++)
				{
					Console.WriteLine("Internet Explorer Window width is less than 1920");
				}
			}
				
		}
	}
}
