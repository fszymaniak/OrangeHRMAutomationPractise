using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.App.UI.Tests.Constants.Configuration
{
    public class ExceptionMessages
    {
        public static string WebdriverNotInitialized => "The WebDriver browser instance was not initialized. You should first call the method Start.";

        public static string WebdriverWaitNotInitialized => "The WebDriver wait instance was not initialized. You should first call the method Start.";
    }
}
