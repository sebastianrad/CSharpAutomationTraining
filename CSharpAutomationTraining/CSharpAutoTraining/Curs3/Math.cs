using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class Math
    {
        public double Division(int num1, int num2)
        {
            double result = 0;
            try
            {
                result = num1 / num2;
            }
            catch(DivideByZeroException e1)
            {
                Console.WriteLine("Cannot divide by 0");
            }
            catch(Exception e)
            {

            }
            finally
            {
                //se va executa indiferent daca codul din try fail-uieste sau nu
                Console.WriteLine("finally code");
            }
            return result;
        }
        public void TestException()
        {
            throw new Exception("my exception goes here");
        }
    }
}
