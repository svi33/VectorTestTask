using FirstFormTest.Infrastruture;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace FirstFormTest.PageObjects
{
    class FirstFormPage : BasePage
    {
        private readonly By firstForm = By.Id("comp-jxd8gcbo");
        private readonly By inputFullName = By.Id("input_comp-jxd8gccb");
        private readonly By inputEmail = By.Id("input_comp-k5hb1d85");
        private readonly By btnJoinNow = By.CssSelector("#comp-jxd8gccw button"); //John Now error?
        private readonly By successMessage = By.CssSelector("div #comp-k5h9ba5e");

        public FirstFormPage(IWebDriver driver) : base(driver)
        {

        }

        public bool CheckFindFirstForm()
        {
            return WaitUntil.CheckFindElement(driver, firstForm);
        }

        public bool CheckFindInputFullName()
        {
            return WaitUntil.CheckFindElement(driver, inputFullName);
        }

        public bool CheckFindInputEmail()
        {
            return WaitUntil.CheckFindElement(driver, inputEmail);
        }

        public bool CheckFindBtnConfirm()
        {
            return WaitUntil.CheckFindElement(driver, btnJoinNow);
        }
        public bool CheckFindSuccessMessageDiv()
        {
            return WaitUntil.CheckFindElement(driver, successMessage);
        }


        public bool CheckSuccessMesVisible()
        {
            var mesageCheck = driver.FindElement(successMessage);
            return mesageCheck.Displayed;
        }

        public void InputInFullName(string fullName)
        {
            var inputName = driver.FindElement(inputFullName);
            inputName.SendKeys(fullName);           
        }

        public void InputInEmail(string email)
        {
            var inputTxtEmail = driver.FindElement(inputEmail);
            WaitUntil.WaitElementClick(driver, inputEmail);
            inputTxtEmail.SendKeys(email);
        }

        public void ButtonClick()
        {
            var btnClick = driver.FindElement(btnJoinNow);
            WaitUntil.WaitElementClick(driver,btnJoinNow);
            btnClick.Click();
        }

        public bool GetMessageCheck()
        {
            var mesageCheck = driver.FindElement(successMessage);
            return mesageCheck.Displayed;          
        }
    
    }
}
