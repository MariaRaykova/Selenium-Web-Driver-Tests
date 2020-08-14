using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace SeleniumWebDriverTests
{
    public class LocalGrids
    {

        private IJavaScriptExecutor _javaScriptExecutor;
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.PlatformName = "windows";
            options.BrowserVersion = "77.0";

            _driver = new RemoteWebDriver(new Uri("http://172.16.1.125:36251/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(18)); //адреса на нопа
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30); //препоръчително, защото agent-итте са бавни и има 5-6 браузъра. Това са горни лимити все пак
        }
        [Test]
        public void FirstTest()
        {
            _driver.Url = "https://saucelabs.com/";

            _driver.Navigate().GoToUrl("https://www.automatetheplanet.com/compelling-sunday-14022016/");
            var link = _driver.FindElement(By.PartialLinkText("Previous post"));
            var jsToBeExecuted = $"window.scroll(0, {link.Location.Y};";
            ((IJavaScriptExecutor)_driver).ExecuteScript(jsToBeExecuted);
            link.Click();

            Assert.AreEqual("10 Advanced WebDriver Tips ...", _driver.Title);
        }
        [TearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }

    }
}
