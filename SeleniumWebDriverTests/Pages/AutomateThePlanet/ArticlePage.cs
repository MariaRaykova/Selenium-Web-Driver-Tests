using OpenQA.Selenium;
using SeleniumWebDriverTests.Pages;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumWebDriverTest.Pages.AutomateThePlanet
{
    public class ArticlePage : BasePage
    {
        public ArticlePage(IWebDriver driver) 
            : base(driver)
        {
        }
        public IWebElement QickNavigaion => Driver.FindElement(By.ClassName("tve_ct_title"));
        public List<IWebElement> NavigationMainTitles => Driver.FindElements(By.ClassName("tve_ct_level0")).ToList(); //главните раздели
        public List<IWebElement> NavigationSecondaryTitles => Driver.FindElements(By.ClassName("tve_ct_level1")).ToList(); //подразделите

        public List<IWebElement> MainHeader => Driver.FindElements(By.XPath("//*[@id='tve_flt']//h2")).ToList(); 
        public List<IWebElement> SecondaryHeader => Driver.FindElements(By.XPath("//*[@id='tve_flt']//h3")).ToList(); 
    }
}
