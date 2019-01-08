using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace OrangeHRM.App.UI.Tests.Pages
{
    

    class Page
    {
        protected RemoteWebDriver Driver { get; }
        //public Page(RemoteWebDriver driver)
        public Page()
        {
            Driver = UITestsBase.InitDriver();
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

        public bool ElementDoesNotExist(string xpath)
        {
            return !DoesElementExist(xpath);
        }

        public void RefreshPage()
        {
            Driver.Navigate().Refresh();
        }
    }
}

