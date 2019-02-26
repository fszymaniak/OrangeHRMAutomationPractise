using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace OrangeHRM.App.UI.Tests
{
    public static class UITestsBase
    {
        private static WebDriverWait _driverWait;

        private static RemoteWebDriver _driver;

        public static RemoteWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    throw new NullReferenceException(Constants.Configuration.ExceptionMessages.WebdriverNotInitialized);
                }
                return _driver;
            }
            private set
            {
                _driver = value;
            }
        }

        public static WebDriverWait DriverWait
        {
            get
            {
                if (_driverWait == null || _driver == null)
                {
                    throw new NullReferenceException(Constants.Configuration.ExceptionMessages.WebdriverWaitNotInitialized);
                }
                return _driverWait;
            }
            private set
            {
                _driverWait = value;
            }
        }

        public static RemoteWebDriver InitDriver()
        {
            if (_driver == null)
            {
                var chromeOptions = new ChromeOptions();

                if (UITestsConfiguration.ChromeHeadlessOn)
                {
                    chromeOptions.AddArgument(Constants.Configuration.ChromeArguments.Headless);
                    chromeOptions.AddArgument(Constants.Configuration.ChromeArguments.DisableGpu);
                    chromeOptions.AddArgument(Constants.Configuration.ChromeArguments.AllowInsecureLocalhost);
                }
                else
                {
                    chromeOptions.AddArguments(UITestsConfiguration.DriverDefaultLanguage);
                    chromeOptions.AddArgument(UITestsConfiguration.DriverDefaultWindowSize);
                }
                _driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory, chromeOptions);
            }
            return _driver;
        }

        public static void StopBrowser()
        {
            Driver.Quit();
            Driver = null;
            DriverWait = null;
        }
    }
}
