using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumWebDriverTests.Pages
{
    public abstract class BasePage //abstract - не могат от него да се създават инстанции t.e. var basePage = New BasePage();
    {
       
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            Actions = new Actions(driver); 
    }

        public IWebDriver Driver { get; private set; }
        public WebDriverWait Wait { get; private set; }
        public Actions Actions { get; private set; }

        public virtual void Navigate(string url) //параметри малки букви. Virtual - вс детенце долу си прави своята навигация
        {
            Driver.Url = url;
        }
        public virtual void ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        public virtual void Scroll(int offset) //това е ScrollUp
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript($"window.scrollBy(0, -{offset});");
        }

    }

}
