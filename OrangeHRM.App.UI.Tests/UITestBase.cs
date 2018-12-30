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
        private static WebDriverWait driverWait;

        private static RemoteWebDriver driver;

        public static RemoteWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }
                return driver;
            }
            private set
            {
                driver = value;
            }
        }

        public static WebDriverWait DriverWait
        {
            get
            {
                if (driverWait == null || driver == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return driverWait;
            }
            private set
            {
                driverWait = value;
            }
        }

        public static RemoteWebDriver InitDriver()
        {
            if (Driver == null)
            {
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
                driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory, chromeOptions);
            }
            return driver;
        }

        public static void StopBrowser()
        {
            Driver.Quit();
            Driver = null;
            DriverWait = null;
        }
    }
}
