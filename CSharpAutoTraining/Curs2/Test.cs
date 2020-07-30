using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAutoTraining.Curs3;
using CSharpAutoTraining.Curs4;
/*
namespace CSharpAutoTraining.Curs2
{
	class Test
	{
		static void Main(string[] args) 
		{
			//CURS 2

			Browser browser = new Browser();
			Chrome chrome = new Chrome();
			{
				Console.WriteLine(chrome.WindowWidth_int);
				chrome.windowWidth();
			}
			//For Firefox convert int to string, string to double, and double to int and display in console the values.
		   Firefox firefox = new Firefox();
			{
				int value1 = 10; 
				string value2 = "11.123";
				double value3 = 12.3;

				var ConvertToString = Convert.ToString(value1);
				Console.WriteLine("Conversion to string " + ConvertToString + " is of type " + ConvertToString.GetType());

				var ConvertToDouble = Convert.ToDouble(value2);
				Console.WriteLine("Conversion to double " + ConvertToDouble + " is of type " + ConvertToDouble.GetType());

				var ConvertToInt = Convert.ToInt32(value3);
				Console.WriteLine("Conversion to int " + ConvertToInt + " is of type " + ConvertToInt.GetType());
			}
			InternetExplorer internetExplorer = new InternetExplorer();
			{
				internetExplorer.DisplayMultipleTimes();
			}


			//CURS 3
			FirefoxCurs3 firefoxCurs3 = new FirefoxCurs3();
			ChromeCurs3 chromeCurs3 = new ChromeCurs3();
			InternetExplorerCurs3 internetExplorerCurs3 = new InternetExplorerCurs3();
			EdgeCurs3 edgeCurs3 = new EdgeCurs3();
			BrowserCurs3 browserCurs3 = new BrowserCurs3();


			//curs 4

			//In Main method for each object call available methods
			// la clasa BrowserCurs4 nu se poate face new Browser (obiect nou) deoarece este o clasa abstracta, aceasta clasa poate fi apelata doar din alta clasa.
			FirefoxCurs4 firefoxCurs4 = new FirefoxCurs4();
			firefoxCurs4.About();
			firefoxCurs4.Ping();
			firefoxCurs4.StartBrowser();
			firefoxCurs4.WindowWidth = 700;
			Console.WriteLine(firefoxCurs4);

			SkypeCurs4 skypeCurs4 = new SkypeCurs4();
			skypeCurs4.About();
			skypeCurs4.Ping();


			Console.ReadKey();
		}
	}
}
*/