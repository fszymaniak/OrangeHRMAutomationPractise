using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace OrangeHRM.App.UI.Tests.Pages
{
    class LoginPage : Page
    {
        public LoginPage()
        {
            PageUrl = UITestsConfiguration.OrgangeHrmURL;
        }

        private IWebElement UserNameInput => Driver.FindElement(By.XPath("//input[@id='txtUsername']"));

        private IWebElement UserNamePassword => Driver.FindElement(By.XPath("//input[@id='txtPassword']"));

        private IWebElement LoginButton => Driver.FindElement(By.XPath("//input[@id='txtUsername']"));
    }
}
