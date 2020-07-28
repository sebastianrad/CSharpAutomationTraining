using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
	class Chrome
	{
		public int WindowWidth_int = 1930;
		public string WindowWidth_string;
		public double WindowWidth_double;

		public void windowWidth() 
		{
			if (WindowWidth_int > 1920)
			{
				Console.WriteLine("Chrome Window width is more than 1920");
			}
			else 
			{
				Console.WriteLine("Chrome Window width is less than 1920");
			}
		}
	}
}
