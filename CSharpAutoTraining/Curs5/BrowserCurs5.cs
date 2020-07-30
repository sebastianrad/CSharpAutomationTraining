using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
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
        }

        private void FindElement()
        {
            try
            {
                PathImage = "C:\\Casa\\teren2019\\03mai19\\20190502_172939.jpg";
            }
            catch(Exception e)
            {
                Console.WriteLine("he element was not found");
            }
            finally
            {
                PathImage = "C:\\Casa\\teren2019\\03mai19\\20190502_172901.jpg";
            }
            throw new Exception("Still the element was not found");

        }
    }
}
