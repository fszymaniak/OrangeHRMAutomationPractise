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

        private readonly string _invalidCredentialsMessageXP = "//span[@id='spanMessage'][text()='Invalid credentials']"; 

        public LoginPage()
        {
            PageUrl = UITestsConfiguration.OrgangeHrmURL + "auth/login";
        }

        private IWebElement UserNameInput => Driver.FindElement(_userNameInputXP);

        private IWebElement UserPasswordInput => Driver.FindElement(_userPasswordInputXP);

        private IWebElement LoginButton => Driver.FindElement(_loginButtonXP);

        private IWebElement InvalidCredentialsMesssge => Driver.FindElement(_invalidCredentialsMessageXP);
        
        public void EnterCredentials()
        {
            InputName("Admin");
            InputPassword("admin123");
        }

        public void EnterCredentialsWithInvalidUserName()
        {
            InputName("Admin111");
            InputPassword("admin123");
        }

        public void EnterCredentialsWithInvalidPassword()
        {
            InputName("Admin");
            InputPassword("admin1234567");
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

        public void ValidateUnsuccessfulLogin()
        {
            var url = Driver.Url;
            Assert.AreEqual(UITestsConfiguration.OrgangeHrmURL + "auth/validateCredentials", url);
            Assert.True(InvalidCredentialsMesssge.Displayed);
        }
    }
}
