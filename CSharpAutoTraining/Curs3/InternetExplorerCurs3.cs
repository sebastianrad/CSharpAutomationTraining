using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
	public class InternetExplorerCurs3 : BrowserCurs3
	{
		public override void ChangeWindowWidth(int val) 
		{
			Console.WriteLine("This is Internet Explorer Curs3");
		}
	}
}
