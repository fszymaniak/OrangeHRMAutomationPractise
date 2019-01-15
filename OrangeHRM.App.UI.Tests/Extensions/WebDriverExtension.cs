using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace OrangeHRM.App.UI.Tests.Extensions
{
    public static class WebDriverExtension
    {
        public static IWebElement FindElement(this RemoteWebDriver driver, string xpath, int timeoutInSeconds = 10)
        {
            driver.ExplicitWait(xpath, timeoutInSeconds);
            return driver.FindElement(By.XPath($"{xpath}"));
        }

        public static void ImplicitWait(this RemoteWebDriver driver, int implicitWaitTime = 10)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitTime);
        }

        public static void ExplicitWait(this RemoteWebDriver driver, string xpath, int waitTime = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
            wait.Until(d => driver.FindElement(By.XPath($"{xpath}")).Displayed);
        }


    }
}
