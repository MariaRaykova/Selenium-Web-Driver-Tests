using OpenQA.Selenium;


namespace SeleniumWebDriverTest.Pages
{
    public class TooltipPage : NavigationBarPage
    {
        public TooltipPage(IWebDriver driver) 
            : base(driver)
        {
        }
        public IWebElement Input => Driver.FindElement(By.Id("toolTipTextField"));
        public IWebElement ToolDipDiv => Driver.FindElement(By.Id("textFieldToolTip"));
        public void HoverTooltip()
        {
            Actions.MoveToElement(Input).Perform();
        }
    }
}
