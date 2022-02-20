using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;
using System.Threading.Tasks;

namespace FirstFormTest.Infrastruture
{
    public static class WaitUntil
    {
        public static void WaitSomeInterval (int seconds=10)
        {
            Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
        }

        public static void WaitElementClick(IWebDriver webdriver,By locator, int seconds = 10)
        {
            new WebDriverWait(webdriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(locator));
            new WebDriverWait(webdriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        
        public static bool CheckFindElement (IWebDriver webdriver, By locator, int seconds = 10)
        {
            try
            {
                new WebDriverWait(webdriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementExists(locator));
                return true;
            }
            catch 
            {
                return false;
            }

        }
    }
}
