using OrangeHRM.App.UI.Tests.Pages;
using TechTalk.SpecFlow;

namespace OrangeHRM.App.UI.Tests.Steps
{
    [Binding]
    public sealed class LoginLogoutSteps
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
            _loginPage.logIn();
        }

        [When(@"I press login button")]
        public void WhenIPressLoginButton()
        {
            _loginPage.clickLoginButton();
        }

        [Then(@"I can log to the application")]
        public void ThenICanLogToTheApplication()
        {
            _loginPage.validateLoginSuccess();
        }
    }
}
