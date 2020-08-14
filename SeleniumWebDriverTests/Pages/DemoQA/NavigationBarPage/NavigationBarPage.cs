using OpenQA.Selenium;
using SeleniumWebDriverTests.Pages;

namespace SeleniumWebDriverTest.Pages
{
    public class NavigationBarPage : BasePage
    {
        public NavigationBarPage(IWebDriver driver)
            : base(driver)
        {
        }
        public IWebElement TooltipButton => Driver.FindElement(By.XPath($".//*[normalize-space(text())='Tool Tips']")); 
    }
}
