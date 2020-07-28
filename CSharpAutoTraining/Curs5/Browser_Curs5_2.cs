using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    internal class Browser_Curs5_2:BrowserHelper_Curs5
    {
        internal void SendTextToElement()
        {
            try
            {
                FindElement();
            }
            catch (Exception e)
            {
                CaptureScreen();
            }
             void FindElement()
            {
                try
                {
                    PathImage = "empty";
                }
                finally
                {
                    PathImage = "empty";
                }
                throw new Exception("The element was not found");
            }

        }

    }
}
