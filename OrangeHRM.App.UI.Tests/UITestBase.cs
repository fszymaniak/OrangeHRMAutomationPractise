using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace OrangeHRM.App.UI.Tests
{
    public static class UITestsBase
    {
        private static WebDriverWait _driverWait;

        private static RemoteWebDriver _driver;

        //public static RemoteWebDriver Driver
        //{
        //    get
        //    {
        //        if (_driver == null)
        //        {
        //            throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
        //        }
        //        return _driver;
        //    }
        //    private set
        //    {
        //        _driver = value;
        //    }
        //}

        public static WebDriverWait DriverWait
        {
            get
            {
                if (_driverWait == null || _driver == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
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
            //if (Driver == null)
            //{
                var chromeOptions = new ChromeOptions();

                if (UITestsConfiguration.ChromeHeadlessOn)
                {
                    chromeOptions.AddArgument("--headless");
                    chromeOptions.AddArgument("--disable-gpu");
                    chromeOptions.AddArgument("--allow-insecure-localhost");

                }
                else
                {
                    chromeOptions.AddArguments(UITestsConfiguration.DriverDefaultLanguage);
                    chromeOptions.AddArgument(UITestsConfiguration.DriverDefaultWindowSize);
                }
                _driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory, chromeOptions);
            //}
            return _driver;
        }

        //public static void StopBrowser()
        //{
        //    Driver.Quit();
        //    Driver = null;
        //    DriverWait = null;
        //}
    }
}
