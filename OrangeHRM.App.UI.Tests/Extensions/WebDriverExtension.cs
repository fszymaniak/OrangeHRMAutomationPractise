using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace OrangeHRM.App.UI.Tests.Extensions
{
    public static class WebDriverExtension
    {
        public static IWebElement FindElement(this IWebDriver driver, string xpath, int timeoutInSeconds = 10)
        {
            var byXpath = By.XPath($"{xpath}");
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(byXpath));
            }
            return driver.FindElement(byXpath);
        }
    }
}
