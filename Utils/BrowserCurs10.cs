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
    public class BrowserCurs10
    {

        public IWebDriver driver;

        public void WaitElementToBeVisible(IWebDriver driver, By element, int timeOut)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            var waitCondition = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By)driver.FindElement(By.XPath("//h1"))));
        }


        [Test]
        public void NavigateToWikiPageTest()
        {

            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\driver");
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\Utils\\homepage.html";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();

            //Accesam home page
            Assert.True(driver.Title.Equals("Home page"));

            driver.FindElement(By.Id("email")).SendKeys("admin@domain.org");
            driver.FindElement(By.Id("password")).SendKeys("111111");
            driver.FindElement(By.Id("Login")).Click();

            //Ne asiguram ca suntem pe pagina Dashboard page
            Assert.True(driver.FindElement(By.XPath("//h1[text() = 'Dashboard page']")).Displayed);

            //accesam link-ul WikiPage
            driver.FindElement(By.XPath("//a[@style = 'padding-left:5em'][contains(text(), 'WikiPage' )]")).Click();


            //Ne asiguram ca textul de Wiki is dispalyed
            Thread.Sleep(2000);
            Assert.True(driver.FindElement(By.XPath("//h1[text() = 'WikiPage']")).Displayed);

            //introducem text in text area field
            Thread.Sleep(6000);
            driver.FindElement(By.Id("htmlVersion")).SendKeys("text area field");

        }
    }
}
