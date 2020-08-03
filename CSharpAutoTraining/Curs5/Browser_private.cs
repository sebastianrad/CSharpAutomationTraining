using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    class Browser_private
    {

        private void SendTextToElement()
        {
            try
            {
                FindElement();
            }
            catch (Exception e)
            {
                BrowserHelper.CaptureScreen();
            }
            finally
            {
                BrowserHelper.PathImage = "Captured_Screen_Path Finally - private";
            }
        }

        public void FindElement()
        {
            throw new Exception("FindElement: Element was not found");
        }
    }
}
