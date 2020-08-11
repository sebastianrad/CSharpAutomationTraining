using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    class Browser_Curs5_3 : BrowserHelper_Curs5
    {
        private void SendTextToElement()
        {
            try
            {
                FindElement();
            }
            catch (Exception e)
            {
                CaptureScreen();
            }

        }
        private void FindElement()
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
