﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using Microsoft.Extensions.Configuration;

namespace OrangeHRM.App.UI.Tests
{
    public static class UITestsConfiguration
    {
        public static string OrgangeHrmURL => Configuration["OrangeHrmURL"];

        public static bool ChromeHeadlessOn => bool.Parse(Configuration[nameof(ChromeHeadlessOn)]);

        public static string DriverDefaultLanguage => Configuration["DriverDefaultLanguage"];

        public static string DriverDefaultWindowSize => Configuration["DriverDefaultWindowSize"];
        public static IConfiguration Configuration { get; set; }

        static UITestsConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }
    }
}
