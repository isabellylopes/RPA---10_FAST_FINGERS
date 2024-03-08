using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPA___10_FAST_FINGERS.Uteis
{
    internal class U_Selenium
    {
        


        internal static WebDriverWait WDWait(IWebDriver driver, int seconds) 
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            return wait;
        }



        internal static void Find_Click(IWebDriver driver, string? element, int seconds)
        {
            WebDriverWait wait = WDWait(driver, seconds);

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element))).Click();
        }


        internal static void Find_Send(IWebDriver driver, string key)
        {

            driver.FindElement(By.Id("inputfield")).SendKeys(key);
            driver.FindElement(By.Id("inputfield")).SendKeys(" ");
        }



        internal static void Find_Text(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("row1"));

       
            IList<IWebElement> spanElements = element.FindElements(By.TagName("span"));

          
            foreach (IWebElement span in spanElements)
            {
                Console.WriteLine(span.Text);
                Find_Send(driver, span.Text);
            }

            
        }


        internal static void Find_Alert(IWebDriver driver)
        {
            WebDriverWait wait = WDWait(driver, 60);

            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
            
            alert.Accept();
        }


        internal static string Find_Text_Return(IWebDriver driver, string element, int seconds)
        {
            WebDriverWait wait = WDWait(driver, seconds);

            string return_ = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element))).Text;

            Console.WriteLine(return_);

            return return_;
        }
    }
}
