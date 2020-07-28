using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
	public class BrowserCurs3
	{
		public int WindowWidth_int;
		public string WindowWidth_string;

		public virtual void ChangeWindowWidth(int val) 
		{
			Console.WriteLine("This is ChangeWindowWidth Curs3");
		}

		public virtual void About() 
		{
			Console.WriteLine("This is About Curs3");
		}
	}
}
