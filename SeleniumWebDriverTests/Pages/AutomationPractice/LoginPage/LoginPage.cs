using OpenQA.Selenium;

namespace SeleniumWebDriverTests.Pages
{
    public class LoginPage : BasePage 
    {
       
        public LoginPage(IWebDriver driver)
        : base(driver)
        {
        }
        public new string Url => "http://automationpractice.com/index.php?controller=my-account"; //property
        public IWebElement Email => Driver.FindElement(By.Name("email_create"));
        public IWebElement Submit => Driver.FindElement(By.Name("SubmitCreate"));
       
    }
}
