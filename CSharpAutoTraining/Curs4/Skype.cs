using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class Skype: CSharpAutoTraining.Curs4.IComponent, CSharpAutoTraining.Curs4.INetwork
    {

        // implement method About() from IComponent interface
        public void About()
        {
            Console.WriteLine("About: Skype version used: Skype for business");
        }

        // implement method Ping() from INetwork interface
        public void Ping()
        {
            Console.WriteLine("Ping: Skype responded to Ping");
        }
    }
}
