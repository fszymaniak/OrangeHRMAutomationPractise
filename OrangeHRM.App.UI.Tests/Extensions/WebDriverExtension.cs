using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Remote;

namespace OrangeHRM.App.UI.Tests.Extensions
{
    public static class WebDriverExtension
    {
        public static IWebElement FindElement(this RemoteWebDriver driver, string xpath, int timeoutInSeconds = 10)
        {
            driver.ImplicitWait(timeoutInSeconds);
            return driver.FindElement(By.XPath($"{xpath}"));
        }

        public static void ImplicitWait(this RemoteWebDriver driver, int implicitWaitTime = 10)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitTime);
        }
    }
}
