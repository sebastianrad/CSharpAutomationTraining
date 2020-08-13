using OpenQA.Selenium;
using System;

namespace PageObjects
{
    public class HomePageCurs11
    {
        //Browser browser;
        private IWebDriver driver;
        private string initialWondow;

        private IWebElement wikiLink { get { return driver.FindElement(By.LinkText("WikiPage")); } }
        private IWebElement email { get { return driver.FindElement(By.Id("email")); } }
        private IWebElement password { get { return driver.FindElement(By.Id("password")); } }

        private By loginButtonBy = By.Id("Login");
        private IWebElement loginButton { get { return driver.FindElement(loginButtonBy); } }

        private IWebElement multipleFramesPageLink { get { return driver.FindElement(By.LinkText("Window+Frame")); } }
        private IWebElement wikiPageLink { get { return driver.FindElement(By.LinkText("Window")); } }

        public HomePageCurs11(IWebDriver driver)
        {
            this.driver = driver;
            //browser = new Browser(this.driver);
        }

        public HomePageCurs11 Login(string email, string password)
        {
            this.email.SendKeys(email);
            this.password.SendKeys(password);
            loginButton.Click();
            return this;
        }

    }
}
