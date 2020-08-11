using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    public class Browser_Curs5_1 : BrowserHelper_Curs5
    {
        public void SendTextToElement()
        {
            try
            {
                FindElement();
            }
            catch(Exception e)
            {
                CaptureScreen();
            }
            finally
            {
                PathImage = "empty";
            }
              
        }
        public void FindElement()
        {
            throw new Exception("The element was not found");
        }
    }
}
