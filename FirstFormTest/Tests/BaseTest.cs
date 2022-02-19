using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace FirstFormTest.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        [SetUp]
        public virtual void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://tarasmysko89.wixsite.com/vectortesttask01");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}
