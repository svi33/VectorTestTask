using FirstFormTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace FirstFormTest.Tests
{
    class InputFirstFormTest : BaseTest
    {
        [SetUp]
        public override void SetUp()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
            driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl("https://tarasmysko89.wixsite.com/vectortesttask01");
        }

        [Test]
        public void FindForm1()
        {
            FirstFormPage formFirst = new FirstFormPage(driver);
            Assert.IsTrue(formFirst.CheckFindFirstForm());
        }

        [Test]
        public void negativeInputTextInForm1()
        {
            FirstFormPage formFirst = new FirstFormPage (driver);
            formFirst.InputInFullName("name");

            Thread.Sleep(3000);
            formFirst.ButtonCheck();
            Thread.Sleep(3000);
            Assert.IsFalse(formFirst.GetMessageCheck());
        }



        [Test]
        public void InputTextInForm1()
        {
            FirstFormPage formFirst = new FirstFormPage(driver);
            formFirst.InputInFullName("name");
            formFirst.InputInEmail("email");
            Thread.Sleep(5000);
            formFirst.ButtonCheck();
            Thread.Sleep(3000);
            Assert.IsTrue(formFirst.GetMessageCheck());
        }


    }
}
