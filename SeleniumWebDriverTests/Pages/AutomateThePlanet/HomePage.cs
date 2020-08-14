using OpenQA.Selenium;
using SeleniumWebDriverTests.Pages;

namespace SeleniumWebDriverTest.Pages.AutomateThePlanet
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) 
            : base(driver)
        {
        }
        public IWebElement BlogButton => Driver.FindElement(By.Id("menu-item-6"));
    }
}
