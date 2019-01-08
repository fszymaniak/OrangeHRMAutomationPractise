using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OrangeHRM.App.UI.Tests.Settings;

namespace OrangeHRM.App.UI.Tests.Pages
{
    

    public class LoginTestsSetup : TestHooks
    {
        protected static RemoteWebDriver WebDriver { get; private set; }

        [SetUp]
        public void Setup()
        {
            WebDriver = driver;
            WebDriver.Navigate().GoToUrl(UITestsConfiguration.OrgangeHrmURL);
        }
    }
}
