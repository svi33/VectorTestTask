using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace FirstFormTest.Tests
{
    public class BaseTest
    {
        protected readonly string websiteURL = "https://tarasmysko89.wixsite.com/vectortesttask01";
        protected IWebDriver driver;
        [SetUp]
        public virtual void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(websiteURL);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}
