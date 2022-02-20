using FirstFormTest.Infrastruture;
using FirstFormTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace FirstFormTest.Tests
{
    class InputFirstFormTest : BaseTest
    {
        private string fullName = "name";
        private string email = "email";

        [SetUp]
        public override void SetUp()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
            driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl(websiteURL);
        }

        [Test]
        public void ClickWithoutInputText()
        {
            FirstFormPage formFirst = new FirstFormPage(driver);
            formFirst.ButtonClick();
            Assert.IsFalse(formFirst.GetMessageCheck());
        }
        
        [Test]
        public void partialInputTextForm1()
        {
            FirstFormPage formFirst = new FirstFormPage(driver);
            formFirst.InputInFullName(fullName);
            formFirst.ButtonClick();
            Assert.IsFalse(formFirst.GetMessageCheck());
        }


        [Test]
        public void InputTextInForm1()
        {
            FirstFormPage formFirst = new FirstFormPage(driver);
            formFirst.InputInFullName(fullName);
            formFirst.InputInEmail(email);
            WaitUntil.WaitSomeInterval(3);
            formFirst.ButtonClick();
            WaitUntil.WaitSomeInterval(3);
            Assert.IsTrue(formFirst.GetMessageCheck());
        }


    }
}
