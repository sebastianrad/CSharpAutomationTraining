using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class EdgeCurs3 : IECurs3
    {
        //variables
        int version = 84;

        public void NewFeatureFunction()
        {
            Console.WriteLine("New feature version = " + version);
        }
    }
}
