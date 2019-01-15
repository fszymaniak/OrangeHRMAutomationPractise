using OrangeHRM.App.UI.Tests.Pages;
using TechTalk.SpecFlow;

namespace OrangeHRM.App.UI.Tests.Steps
{
    [Binding]
    public class LoginLogoutSteps : LoginTestsSetup
    {

        private LoginPage loginPage = new LoginPage();

        [Given(@"I am on OrangeHRM App Login page")]
        public void GivenIAmOnOrangeHRMAppLoginPage()
        {
            loginPage.GoToPageUrl();
        }

        [Given(@"I have entered login credentials")]
        public void GivenIHaveEnteredLoginCredentials()
        {
            loginPage.EnterCredentials();
        }

        [Given(@"I have entered login credentials with invalid user name")]
        public void GivenIHaveEnteredInvalidUserName()
        {
            loginPage.EnterCredentialsWithInvalidUserName();
        }

        [Given(@"I have entered login credentials with invalid password")]
        public void GivenIHaveEnteredInvalidPassword()
        {
            loginPage.EnterCredentialsWithInvalidPassword();
        }

        [When(@"I press login button")]
        public void WhenIPressLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I can log to the application")]
        public void ThenICanLogToTheApplication()
        {
            loginPage.ValidateLoginSuccess();
        }

        [Then(@"I cannot log to the application")]
        public void ThenICannotLogToTheApplication()
        {
            loginPage.ValidateUnsuccessfulLogin();
        }
    }
}
