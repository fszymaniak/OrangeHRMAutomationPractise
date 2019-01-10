using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace OrangeHRM.App.UI.Tests.Settings
{
    [Binding]
    public class TestHooks
    {
        protected RemoteWebDriver driver; 

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = UITestsBase.Driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
            driver.Dispose();
        }
    }
}
