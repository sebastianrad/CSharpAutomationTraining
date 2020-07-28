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
              
        }
        public void FindElement()
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
