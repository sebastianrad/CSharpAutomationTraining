using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Utils
{
    [TestFixture]
    class WikiPageCurs10
    {
        public IWebDriver driver;

        [Test]
        public void WikiPageTest()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\driver");
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\Utils\\wikipage.html";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();


            //ne asiguram ca suntem pe pagina WikiPage
            IWebElement element = driver.FindElement(By.XPath("//header[1]"));

            Assert.True(driver.FindElement(By.XPath("//header[1]//a[text() = 'WikiPage']")).Text.Equals("WikiPage"));

        }

        [Test]
        public void SelectHTMLVersions()
        {

            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\driver");
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\Utils\\wikipage.html";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            SelectElement select = new SelectElement(driver.FindElement(By.Id("htmlversions")));
            Thread.Sleep(5000);
            select.SelectByValue("2");
            Thread.Sleep(2000);
            select.SelectByValue("3.2");
            Thread.Sleep(2000);
            select.SelectByValue("4.0");
            Thread.Sleep(2000);
            select.SelectByText("HTML 5");

        }

        [Test]
        public void HeaderIsPresent()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\driver");
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\Utils\\wikipage.html";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            Thread.Sleep(3000);
            Console.WriteLine(IsHeaderPresent(By.Id("header")).ToString());

        }
        public bool IsHeaderPresent(By element)
        {
            Thread.Sleep(3000);
            try
            {
                driver.FindElement(By.Id("header"));
                return true;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

        [Test]
        public void FooterIsPresent()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\driver");
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\Utils\\wikipage.html";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            Thread.Sleep(3000);
            Console.WriteLine(IsHeaderPresent(By.XPath("//footer")).ToString());
        }
        public bool IsFooterPresent(By element)
        {
            Thread.Sleep(3000);
            try
            {
                driver.FindElement(By.XPath("//footer"));
                return true;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

    }
}
