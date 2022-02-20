using FirstFormTest.Infrastruture;
using FirstFormTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace FirstFormTest.Tests
{
    class InputSecondFormTest : BaseTest
    {
        private string fullName = "name";
        private string email = "some@email.com";

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
            SecondFormPage formFirst = new SecondFormPage(driver);
            formFirst.ButtonClick();
            Assert.IsFalse(formFirst.GetMessageCheck());
        }

        [Test]
        public void partialInputTextForm1()
        {
            SecondFormPage formFirst = new SecondFormPage(driver);
            formFirst.InputInFullName(fullName);
            formFirst.ButtonClick();
            Assert.IsFalse(formFirst.GetMessageCheck());
        }


        [Test]
        public void InputTextInForm1()
        {
            SecondFormPage formFirst = new SecondFormPage(driver);
            formFirst.InputInFullName(fullName);
            formFirst.InputInEmail(email);
            WaitUntil.WaitSomeInterval(3);
            formFirst.ButtonClick();
            WaitUntil.WaitSomeInterval(3);
            Assert.IsTrue(formFirst.GetMessageCheck());
        }


    }
}
