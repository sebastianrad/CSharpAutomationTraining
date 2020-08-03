using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Curs4
{
    class Skype : IComponent, INetwork
    {
        public void About()
        {
            Console.WriteLine("Skype: About");
        }

        public void Ping()
        {
            Console.WriteLine("Ping for Skype is OK");
        }
    }
}
