using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Tests
{
    public class TestBaseCurs11
    {
        public IWebDriver driver;

        [SetUp]
        public void Initialization()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\driver");
            driver.Url = "file:///C:\\workspace\\SeleniumFramework\\multiples_windows\\homepage.html";
            //driver.Url = SeleniumFramework.Resource1.Url;
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(3000);
            driver.Close();
        }
    }
}
