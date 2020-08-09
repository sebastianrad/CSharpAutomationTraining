using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace TestClassLibrary.Curs10
{
    [TestFixture]
    class TestCurs10 : TestBaseCurs10
    {
      
        [Test]
        public void GetPageTitleTest()
        {
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\TestClassLibrary\\homepage.html";
            driver.Manage().Window.Maximize();

            Assert.True(driver.Title.Equals("Home page"));
            Thread.Sleep(2000);
            //tb10.TearDown();
        }

        [Test]
        public void EmailInputIsDisplayedTest()
        {
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\TestClassLibrary\\homepage.html";
            driver.Manage().Window.Maximize();

            Assert.True(driver.FindElement(By.Id("email")).Displayed);
            Thread.Sleep(2000);
        }

        [Test]
        public void PasswordInputIsDisplayedTest()
        {
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\TestClassLibrary\\homepage.html";
            driver.Manage().Window.Maximize();

            Assert.True(driver.FindElement(By.Id("password")).Displayed);
            Thread.Sleep(2000);
        }

        [Test]
        public void LoginButtonIsDisplayedTest()
        {
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\TestClassLibrary\\homepage.html";
            driver.Manage().Window.Maximize();

            Assert.True(driver.FindElement(By.Id("Login")).Displayed);
            Thread.Sleep(2000);
        }

        [Test]
        public void LinksDisplayedTest()
        {
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\TestClassLibrary\\homepage.html";
            driver.Manage().Window.Maximize();

            var links = driver.FindElements(By.XPath("//a"));

            foreach (var elem in links)
            {
                Assert.True(elem.Displayed);
            }

        }

        [Test]
        public void ErrorMessageDisplayedTest()
        {
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\TestClassLibrary\\homepage.html";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("Login")).Click();
            var EmailError = driver.FindElements(By.XPath("//p[@style = 'color:#FF0000']"));

            foreach (var elem in EmailError)
            {
                Assert.True(elem.Displayed);
            }

            Thread.Sleep(2000);
            driver.Navigate().Refresh();


            var PasswordError = driver.FindElements(By.XPath("//p[@style = 'color:#FF0000']"));

            foreach (var elem in PasswordError)
            {
                Assert.False(elem.Displayed);
            }
        }

        [Test]
        public void HeaderLinksAreDisplayedTest()
        {
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\TestClassLibrary\\homepage.html";
            driver.Manage().Window.Maximize();

            var HeaderLinks = driver.FindElements(By.XPath("//div[@id = 'header']//a"));

            foreach (var elem in HeaderLinks)
            {
                Assert.True(elem.Displayed);
            }

            Thread.Sleep(2000);

        }

        [Test]
        public void FooterLinksAreDisplayedTest()
        {
            driver.Url = "file:///C:\\workspace\\CSharpAutomationTraining\\TestClassLibrary\\homepage.html";
            driver.Manage().Window.Maximize();

            var FooterLinks = driver.FindElements(By.XPath("//li"));

            foreach (var elem in FooterLinks)
            {
                Assert.True(elem.Displayed);
            }

        }
    }
}

