
using OpenQA.Selenium;
using SeleniumWebDriverTests.Pages;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumWebDriverTest.Pages.AutomateThePlanet
{
    public class BlogPage : BasePage
    {
        public BlogPage(IWebDriver driver) 
            : base(driver)
        {
        }
        public List<IWebElement> Articles => Wait
            .Until(d => d.FindElements(By.XPath("//*[@class='so-panel widget widget_categorylist']//article")).ToList());
    }
  
}
