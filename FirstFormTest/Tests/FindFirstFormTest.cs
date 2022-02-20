using FirstFormTest.PageObjects;
using NUnit.Framework;

namespace FirstFormTest.Tests
{
    class FindFirstFormTest:BaseTest
    {
        [Test]
        public void FindForm1()
        {
            FirstFormPage formFirst = new FirstFormPage(driver);

            Assert.IsTrue(formFirst.CheckFindFirstForm());
            Assert.IsTrue(formFirst.CheckFindInputFullName());
            Assert.IsTrue(formFirst.CheckFindInputEmail());
            Assert.IsTrue(formFirst.CheckFindBtnConfirm());
            Assert.IsTrue(formFirst.CheckFindSuccessMessageDiv()); 
            Assert.IsFalse(formFirst.GetMessageCheck());
        }

    }
}
