using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OrangeHRM.App.UI.Tests.Extensions;

namespace OrangeHRM.App.UI.Tests.Pages
{
    class LoginPage : Page
    {
        public LoginPage()
        {
            PageUrl = UITestsConfiguration.OrgangeHrmURL;
        }

        private IWebElement UserNameInput => Driver.FindElement("//input[@id='txtUsername']");

        private IWebElement UserNamePassword => Driver.FindElement("//input[@id='txtPassword']");

        private IWebElement LoginButton => Driver.FindElement("//input[@id='txtUsername']");
    }
}
