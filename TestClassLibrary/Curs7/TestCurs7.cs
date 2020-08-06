using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassLibrary.Curs7
{
    [TestFixture]
    class TestCurs9 : BrowserCurs7
    {

        [Test]
        public void BrowserStartTest1()
        {
            Assert.True(StartBrowser().Equals(true));
        }

        [Test]
        public void BrowserStartTest2()
        {
            Assert.True(StartBrowser().Equals(false));
        }

        [Test]
        public void  GetPageTitleTest1()
        {
            //Method 1

            String actualTitle = GetPageTitle();
            String expectedTitle = "browser is open";
            Assert.AreEqual(actualTitle, expectedTitle);


            //Method 2

            //Assert.True(GetPageTitle().Equals("browser is open"));
        }

        [Test]
        public void GetPageTitleTest2()
        {
            
            Assert.True(GetPageTitle().Contains("browser"));

          
            //Method 2
            //StringAssert.Contains(GetPageTitle(), "browser");
        }

        [Test]
        public void GetBrowserWidthTest1()
        {
            Assert.Equals(GetBrowserWidth(), 1920);
        }

        [Test]
        public void GetBrowserWidthTest2()
        {
            Assert.Less(GetBrowserWidth(), 1920);
        }

        [Test]
        public void GetBrowserWidthTest3()
        {
            Assert.Greater(GetBrowserWidth(), 1920);
        }

    }
}
