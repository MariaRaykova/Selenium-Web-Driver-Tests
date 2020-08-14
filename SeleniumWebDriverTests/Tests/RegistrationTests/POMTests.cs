using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SeleniumWebDriverTests.Pages;
using System.IO;
using System.Reflection;


namespace SeleniumWebDriverTests
{
    [TestFixture]
    public class POMTests : BaseTest
    {
        private RegistrationUser _user;
        private RegistrationPage _regPage;
        private LoginPage _loginPage;

        [SetUp] //винаги си правим сет ъп метод
        public void ClassInit()
        {
            _loginPage = new LoginPage(Driver);
            _regPage = new RegistrationPage(Driver);

            _user = UserFactory.CreateValidUser();
        }
        [Test]
        public void FillInRegistrationForm() //изнасяме го в отделен клас. Беше в Automation
        {
            // _user.FirstName = ""; //невалиден, няма да въведе име
            //_regPage.Navigate("http://automationpractice.com/index.php?controller=authentication"); не е достъпен директно


            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("гсп;сгкаг");

            Assert.IsTrue(true);


        }
        [Test]
        public void FillRegistrationWithoutFirstName() //негативен тест
        {
            _user.FirstName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("First Name is not filled in");
        }
        [TearDown]
        public void CleanUp()
        {
            var name = TestContext.CurrentContext.Test.Name;
            var result = TestContext.CurrentContext.Result.Outcome;

            var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); //връща директорията на бин-а
            var fullPath = Path.GetFullPath("..\\..\\..\\Screenshots\\");

            if (result == ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile(fullPath + name + ".png", ScreenshotImageFormat.Png);
            }

        }

    }
}
