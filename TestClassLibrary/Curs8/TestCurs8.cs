using System;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestClassLibrary.Curs8
{
    [TestFixture]
    class TestCurs8
    {
        [Test]
        public void GetPageTitleTest()
        {

            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\driver");
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\TestClassLibrary\\homepage.html";
            driver.Manage().Window.Maximize();

            Assert.True(driver.Title.Equals("Home page"));
        }

        [Test]
        public void EmailInputIsDisplayedTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\driver");
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\TestClassLibrary\\homepage.html";
            driver.Manage().Window.Maximize();
            

            Assert.True(driver.FindElement(By.Id("email")).Displayed);
        }

        [Test]
        public void PasswordInputIsDisplayedTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\driver");
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\TestClassLibrary\\homepage.html";
            driver.Manage().Window.Maximize();

            Assert.True(driver.FindElement(By.Id("password")).Displayed);
        }

        [Test]
        public void LoginButtonIsDisplayedTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\driver");
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\TestClassLibrary\\homepage.html";
            driver.Manage().Window.Maximize();

            Assert.True(driver.FindElement(By.Id("Login")).Displayed);
        }

        [Test]
        public void LinksDisplayedTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\driver");
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\TestClassLibrary\\homepage.html";
            driver.Manage().Window.Maximize();

            var links = driver.FindElements(By.XPath("//a"));

            foreach (var elem in links)
            {
                Assert.True(elem.Displayed);
            }

        }
    }
}
