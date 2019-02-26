using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OrangeHRM.App.UI.Tests.Settings;

namespace OrangeHRM.App.UI.Tests.Pages
{
    class Page : TestHooks
    {
        protected RemoteWebDriver Driver { get; }
        public Page()
        {
            if (Driver == null)
            {
                Driver = UITestsBase.InitDriver();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(UITestsConfiguration.WaitingTimeInSeconds);
            }
            else
            {
                Driver = UITestsBase.Driver;
            }
        }

        protected string PageUrl { get; set; }

        public void GoToPageUrl()
        {
            Driver.Navigate().GoToUrl(PageUrl);
        }

        public bool DoesElementExist(string xpath)
        {
            return Driver.FindElements(By.XPath(xpath)).Any();
        }

        public void RefreshPage()
        {
            Driver.Navigate().Refresh();
        }
    }
}
