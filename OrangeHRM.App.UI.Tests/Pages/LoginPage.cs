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

        private IWebElement UserPasswordInput => Driver.FindElement("//input[@id='txtPassword']");

        private IWebElement LoginButton => Driver.FindElement("//input[@id='txtUsername']");
        
        public void logIn()
        {
            inputName("Admin");
            inputPassword("admin123");
            clickLoginButton();
        }

        public void inputName(string name)
        {
            UserNameInput.Clear();
            UserNameInput.SendKeys(name);
        }

        public void inputPassword(string password)
        {
            UserPasswordInput.Clear();
            UserPasswordInput.SendKeys(password);
        }

        public void clickLoginButton()
        {
            LoginButton.Click(); 
        }
    }
}
