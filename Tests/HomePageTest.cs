using NUnit.Framework;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class HomePageTest : TestBaseCurs11
    {
        [Test]
        public void LoggingTest()
        {
            var home = new HomePageCurs11(driver);
            home.Login("admin@domain.org", "111111");
            
        }
        

    }
}
