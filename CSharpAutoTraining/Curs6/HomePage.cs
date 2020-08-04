using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class HomePage
    {
        static void Main(String[] args) 
        {
            IWebDriver driver = new Chrome();
            driver.Navigate().GoToUrl("file:///C:/Users/dgroza/AppData/Local/Temp/Temp1_pages%20(1).zip/homepage.html");
        }
    }
}
