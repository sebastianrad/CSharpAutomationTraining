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
                PathImage = "image";
            }
            catch (Exception e)
            {
                Console.WriteLine("not found");
            }
            finally
            {
                PathImage = "image";
            }
            throw new Exception("not found, try again");

        }
    }
}
