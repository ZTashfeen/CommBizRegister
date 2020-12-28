using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace CommBank.Drivers
{
    public class WebDriver
    {
        public static IWebDriver Driver { get; set; }
        
        public static void NavigateToURL()
        {
            
            Driver = new ChromeDriver();
            Driver.Url = "http://www1.my.commbiz.commbank.com.au/logon/usermaintenance/login.aspx";
            Driver.Navigate();
            Driver.Manage().Window.Maximize();
        }

        public static void CleanUp()
        {
            Console.WriteLine("Cleanup process started");
            try
            {
                var driver = Driver;
                Driver = null;
                if (driver != null)
                {
                    driver.Quit();
                    driver.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured.");
                Console.WriteLine(e.Message);
            }
        }
        public void ClickByCSS(string ByCSS)
        {
            Driver.FindElement(By.CssSelector(ByCSS)).Click();
        }

        public void SendKeysByCSS(string ByCSS, string Text)
        {
            Driver.FindElement(By.CssSelector(ByCSS)).SendKeys(Text);
        }

        public bool ElementExists(string ByCSS)
        {
            bool result = Driver.FindElement(By.CssSelector(ByCSS)).Displayed;
            return result;
        }

        public bool ElementContainsText(string ByCSS, string text)
        {
            bool result = Driver.FindElement(By.CssSelector(ByCSS)).Text.Contains(text);
            return result;
        }

        public void WaitforElementVisible(string ByCSS)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            wait.Until(c => c.FindElement(By.CssSelector(ByCSS)));
        }
    }

}
