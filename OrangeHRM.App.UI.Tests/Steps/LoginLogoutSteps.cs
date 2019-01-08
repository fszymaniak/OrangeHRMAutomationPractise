using OrangeHRM.App.UI.Tests.Pages;
using TechTalk.SpecFlow;

namespace OrangeHRM.App.UI.Tests.Steps
{
    using NUnit.Framework;

    [Binding]
    public sealed class LoginLogoutSteps : LoginTestsSetup
    {

        private LoginPage _loginPage = new LoginPage();

        [Given(@"I am on OrangeHRM App Login page")]
        public void GivenIAmOnOrangeHRMAppLoginPage()
        {
            _loginPage.GoToPageUrl();
        }

        [Given(@"I have entered login credentials")]
        public void GivenIHaveEnteredLoginNameInALoginNameInput()
        {
            _loginPage.LogIn();
        }

        [When(@"I press login button")]
        public void WhenIPressLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then(@"I can log to the application")]
        public void ThenICanLogToTheApplication()
        {
            _loginPage.ValidateLoginSuccess();
        }
    }
}
