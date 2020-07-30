using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    class ProgramCurs5
    {
        static void Main(string[] args)
        {
            BrowserCurs5 browserCurs5 = new BrowserCurs5();
            {
                browserCurs5.SendTextToElement("elem");
                Console.WriteLine("elemntul este: "+ BrowserHelperCurs5.PathImage);
                browserCurs5.SendTextToElement("    ");
                Console.WriteLine("elementul este: "+ BrowserHelperCurs5.PathImage);
                browserCurs5.SendTextToElement("");
                Console.WriteLine("elementul este: " + BrowserHelperCurs5.PathImage);
            }


            Console.ReadKey();
        }
    }
}
