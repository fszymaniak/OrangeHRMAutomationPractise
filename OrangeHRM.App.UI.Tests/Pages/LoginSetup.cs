using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace OrangeHRM.App.UI.Tests.Pages
{
    

    class LoginSetup
    {
        protected RemoteWebDriver WebDriver { get; private set; }

        [SetUp]
        public void Setup()
        {
            WebDriver = UITestsBase.InitDriver();
            WebDriver.Navigate().GoToUrl(UITestsConfiguration.OrgangeHrmURL);
        }

        [TearDown]
        public void Cleanup()
        {
            WebDriver.Quit();
            WebDriver.Dispose();
        }
    }
}
