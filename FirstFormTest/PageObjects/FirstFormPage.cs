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
        private readonly By succsesMessage = By.CssSelector("div #comp-k5h9ba5e");

        public FirstFormPage(IWebDriver driver) : base(driver)
        {

        }

        public bool CheckFindFirstForm()
        {
            try
            {
                driver.FindElement(firstForm);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public void InputInFullName(string fullName)
        {
            try
            {
                var inputName = driver.FindElement(inputFullName);
                inputName.SendKeys(fullName);
                //return true;
            }
            catch
            {
                //return false;

            }

        }

        public void InputInEmail(string email)
        {
            try
            {
                var inputTxtEmail = driver.FindElement(inputEmail);
                inputTxtEmail.SendKeys(email);
                //return true;
            }
            catch
            {
                //return false;

            }

        }

        public void ButtonCheck()
        {
            try
            {
                var btnClick = driver.FindElement(btnJoinNow);
                btnClick.Click();
                // return true;
            }
            catch
            {
                // return false;
            }

        }

        public bool GetMessageCheck()
        {
            var mesageCheck = driver.FindElement(succsesMessage);
            return mesageCheck.Displayed;
            /*
            try
            {
                var mesageCheck = driver.FindElement(succsesMessage);
                
                return mesageCheck.Text;
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
            */
        }
    
    }
}
