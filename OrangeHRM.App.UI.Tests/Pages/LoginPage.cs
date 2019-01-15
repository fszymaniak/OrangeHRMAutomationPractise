using OpenQA.Selenium;
using OrangeHRM.App.UI.Tests.Extensions;
using NUnit.Framework;

namespace OrangeHRM.App.UI.Tests.Pages
{
    class LoginPage : Page
    {
        private readonly string _userNameInputXP = "//input[@id='txtUsername']";

        private readonly string _userPasswordInputXP = "//input[@id='txtPassword']";

        private readonly string _loginButtonXP = "//input[@id='btnLogin']";

        public LoginPage()
        {
            PageUrl = UITestsConfiguration.OrgangeHrmURL + "auth/login";
        }

        private IWebElement UserNameInput => Driver.FindElement(_userNameInputXP);

        private IWebElement UserPasswordInput => Driver.FindElement(_userPasswordInputXP);

        private IWebElement LoginButton => Driver.FindElement(_loginButtonXP);
        
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
