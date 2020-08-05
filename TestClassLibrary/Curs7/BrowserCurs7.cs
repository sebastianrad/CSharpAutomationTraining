using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassLibrary.Curs7
{
    class BrowserCurs7
    {
        private int BroserWidth = 1920;

        public bool StartBrowser()
        {
            return true;
        }

        public String GetPageTitle()
        {
            return "browser is open";
        }

        public int GetBrowserWidth()
        {
            return BroserWidth;
        }
    }
}
