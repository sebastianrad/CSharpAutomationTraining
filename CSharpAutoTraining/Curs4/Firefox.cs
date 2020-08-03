using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class Firefox : CSharpAutoTraining.Curs4.Browser, CSharpAutoTraining.Curs4.IComponent, CSharpAutoTraining.Curs4.INetwork
    {

        // implement method StartBrowser() from Browser clas
        public override void StartBrowser()
        {
            Console.WriteLine("StartBrowser: Firefox browser is started.");
        }

        // implement method About() from IComponent interface
        public void About()
        {
            Console.WriteLine("About: Firefox version used: 78.0.2 (9th of July, 2020)");
        }

        // implement method Ping() from INetwork interface
        public void Ping()
        {
            Console.WriteLine("Ping: Firefox responded to Ping");
        }
    }
}
