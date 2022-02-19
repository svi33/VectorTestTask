using OpenQA.Selenium;

namespace FirstFormTest.PageObjects
{
    public class BasePage
    {
        protected static IWebDriver driver;
        public BasePage(IWebDriver webdriver)
        {
            driver = webdriver;
        }
    }
}
