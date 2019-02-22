using OpenQA.Selenium;
using OrangeHRM.App.UI.Tests.Extensions;
using NUnit.Framework;

namespace OrangeHRM.App.UI.Tests.Pages
{
    using Constants;

    class LoginPage : Page
    {
        private readonly string _userNameInputXP = "//input[@id='txtUsername']";

        private readonly string _userPasswordInputXP = "//input[@id='txtPassword']";

        private readonly string _loginButtonXP = "//input[@id='btnLogin']";

        private readonly string _invalidCredentialsMessageXP = "//span[@id='spanMessage'][contains(text(), 'Invalid credentials')]"; 

        public LoginPage()
        {
            PageUrl = UITestsConfiguration.OrgangeHrmURL + Endpoints.Login;
        }

        private IWebElement UserNameInput => Driver.FindElement(_userNameInputXP);

        private IWebElement UserPasswordInput => Driver.FindElement(_userPasswordInputXP);

        private IWebElement LoginButton => Driver.FindElement(_loginButtonXP);

        private IWebElement InvalidCredentialsMesssge => Driver.FindElement(_invalidCredentialsMessageXP);
        
        public void EnterValidCredentials()
        {
            FillUserNameInput(ValidLoginCredentials.UserAdminName);
            FillUserPasswordInput(ValidLoginCredentials.UserAdminPassword);
        }

        public void EnterInvalidCredentials(string name, string password)
        {
            FillUserNameInput(name);
            FillUserPasswordInput(password);
        }

        public void EnterInValidCredentials(string name, string password)
        {
            FillUserNameInput(name);
            FillUserPasswordInput(password);
        }

        public void FillUserNameInput(string name)
        {
            UserNameInput.Clear();
            UserNameInput.SendKeys(name);
        }

        public void FillUserPasswordInput(string password)
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
            Assert.AreEqual(UITestsConfiguration.OrgangeHrmURL + Endpoints.Dashboard, url);
        }

        public void ValidateUnsuccessfulLogin()
        {
            var url = Driver.Url;
            Assert.AreEqual(UITestsConfiguration.OrgangeHrmURL + Endpoints.ValidateCredentials, url);
            Assert.True(InvalidCredentialsMesssge.Displayed);
        }
    }
}
