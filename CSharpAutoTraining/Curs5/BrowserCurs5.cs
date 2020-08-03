using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Curs5
{
    class BrowserCurs5 : BrowserHelperCurs5
    {
        public void SendTextToElement()
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
