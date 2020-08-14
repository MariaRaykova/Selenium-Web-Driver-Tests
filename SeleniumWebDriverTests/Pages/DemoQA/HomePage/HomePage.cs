using OpenQA.Selenium;
using SeleniumWebDriverTests.Pages;

namespace SeleniumWebDriverTest.Pages
{ 
public class HomePage :BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public IWebElement Widget => Driver.FindElement(By.XPath("//*[normalize-space(text())='Widgets']/ancestor::div[contains(@class,'top-card')]"));
    //не знам как намерихме XPath-a на Widget
    }
}
