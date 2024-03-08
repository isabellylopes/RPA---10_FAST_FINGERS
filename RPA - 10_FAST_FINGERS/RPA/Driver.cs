using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace RPA___10_FAST_FINGERS.RPA
{
    internal class Driver
    {

        internal static IWebDriver Config()
        {


            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            FirefoxOptions options = new FirefoxOptions();
            
            options.AddArgument("--headless");

            return new FirefoxDriver(options);
        }
    }
}
