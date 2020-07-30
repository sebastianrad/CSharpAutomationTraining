using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
	class BrowserCurs5
	{
        public void SendTextToElement(string element)
        {

            try
            {
                if (FindElemet(element))
                {
                    BrowserHelperCurs5.PathImage = element;
                }
                else
                {
                    BrowserHelperCurs5.PathImage = "capture the screen was not succeed ";
                }
                BrowserHelperCurs5.CaptureScreen();
            }

            catch (Exception ex)
            {
                BrowserHelperCurs5.PathImage = ex.Message;
                BrowserHelperCurs5.CaptureScreen();
            }
        }

        public bool FindElemet(string element)
        {
            if (string.IsNullOrWhiteSpace(element))
            {
                throw new Exception("Element was not found");
            }
            else
            {
                return true;
            }
        }
    }
}
