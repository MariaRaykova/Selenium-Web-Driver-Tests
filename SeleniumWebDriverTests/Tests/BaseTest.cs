using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace SeleniumWebDriverTests
{
    [TestFixture]
    public class BaseTest
    {
        private IWebDriver _driver;

        public BaseTest(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver Driver => _driver;

        [OneTimeSetUp]
        public void InitilizeTests()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));// _driver -локална променлива за целия клас, без долна черта за конкретен случай. Ctrl tochka
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                int i = TestContext.CurrentContext.Test.Name.IndexOf('(');
                var path = Path.GetFullPath(Directory.GetCurrentDirectory()
                                      + @"\..\..\..\Screenshots\") +
                                      TestContext.CurrentContext.Test.Name.Substring(0, i) + ".png";
                screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
            }

            _driver.Quit();
        }

        public void DelayForVideo(int seconds = 2)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }
    }
}
