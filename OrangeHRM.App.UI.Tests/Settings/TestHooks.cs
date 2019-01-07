using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace OrangeHRM.App.UI.Tests.Settings
{
    [Binding]
    public sealed class TestHooks
    {
        private RemoteWebDriver _driver; 

        [BeforeScenario]
        public void BeforeScenario()
        {
            this._driver = UITestsBase.Driver; 
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Close();
            _driver.Dispose();
            _driver.Dispose();
        }
    }
}
