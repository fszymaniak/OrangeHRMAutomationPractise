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
            this.driver = UITestsBase.InitDriver(); 
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Dispose();
            driver.Dispose();
        }
    }
}
