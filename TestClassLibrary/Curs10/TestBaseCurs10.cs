using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestClassLibrary.Curs10
{
    class TestBaseCurs10
    {
        public IWebDriver driver;

        [SetUp]
        public void Initialization()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\driver");

        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(3000);
            driver.Close();
        }
    }
}
