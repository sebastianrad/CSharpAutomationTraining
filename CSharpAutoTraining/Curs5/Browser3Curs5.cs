using ACSharpAutoTraining.Curs5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    class Browser3Curs5 : BrowserHelperCurs5
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
            finally
            {
                PathImage = "C:\\worksspace";
            }
        }



        private void FindElement()
        {

            throw new Exception("the element was not found");

        }
    }
}
