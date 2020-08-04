using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    //clasa apeleaza metodele din interface

    public class Skype : IComponent, INetwork// mostenire interfaces
    {
        public void About()//impementare metode
        {}

        public void Ping()//implementare metode 
        { }
    }
}
