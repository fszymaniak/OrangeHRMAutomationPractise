using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace OrangeHRM.App.UI.Tests.Extensions
{
    public static class WebDriverExtension
    {
        public static IWebElement FindElement(this RemoteWebDriver driver, string xpath)
        {
            driver.ExplicitWait(xpath);
            return driver.FindElement(By.XPath($"{xpath}"));
        }

        public static void ImplicitWait(this RemoteWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(UITestsConfiguration.WaitingTimeInSeconds);
        }

        public static void ExplicitWait(this RemoteWebDriver driver, string xpath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(UITestsConfiguration.WaitingTimeInSeconds));
            wait.Until(d => driver.FindElement(By.XPath($"{xpath}")).Displayed);
        }
    }
}
