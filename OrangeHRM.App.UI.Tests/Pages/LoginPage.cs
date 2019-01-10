using OpenQA.Selenium;
using OrangeHRM.App.UI.Tests.Extensions;
using NUnit.Framework;

namespace OrangeHRM.App.UI.Tests.Pages
{
    class LoginPage : Page
    {
        public LoginPage()
        {
            PageUrl = UITestsConfiguration.OrgangeHrmURL + "auth/login";
        }

        private IWebElement UserNameInput => Driver.FindElement("//input[@id='txtUsername']");

        private IWebElement UserPasswordInput => Driver.FindElement("//input[@id='txtPassword']");

        private IWebElement LoginButton => Driver.FindElement("//input[@id='btnLogin']");
        
        public void LogIn()
        {
            InputName("Admin");
            InputPassword("admin123");
        }

        public void InputName(string name)
        {
            UserNameInput.Clear();
            UserNameInput.SendKeys(name);
        }

        public void InputPassword(string password)
        {
            UserPasswordInput.Clear();
            UserPasswordInput.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public void ValidateLoginSuccess()
        {
            var url = Driver.Url;
            Assert.AreEqual(UITestsConfiguration.OrgangeHrmURL + "dashboard", url);
        }
    }
}
