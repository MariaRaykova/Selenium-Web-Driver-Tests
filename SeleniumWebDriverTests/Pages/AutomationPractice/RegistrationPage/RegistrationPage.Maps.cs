using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Diagnostics;


namespace SeleniumWebDriverTests.Pages
{
    public partial class RegistrationPage : BasePage
    {    //partial - един и същ клас се разпростанява в няколко файла. Maps или Елементс - само локаторитеса тук.
        public RegistrationPage(IWebDriver driver)
        : base(driver)
        {
        }

        public new string Url => "http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation";
        public IList<IWebElement> RadioButtons
        {
            get
            {
                var watch = new Stopwatch();
                watch.Start();
                var element = Wait.Until(d => d.FindElements(By.XPath(@"//div[@class=""radio""]//input")));
                watch.Stop();
                Debug.WriteLine(watch.ElapsedMilliseconds);
                // Thread.Sleep(5500);
                return element;
            }
        }

        public IWebElement CutomerFirstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement CutomerLastName => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement CustomerPassword => Driver.FindElement(By.Name("passwd"));

        public SelectElement Date
        {
            get
            {
                IWebElement dateDropDown = Driver.FindElement(By.Id("days"));
                return new SelectElement(dateDropDown);
            }
        }
        public SelectElement Month
        {
            get
            {
                IWebElement monthDD = Driver.FindElement(By.Id("months"));
                return new SelectElement(monthDD);
            }
        }
        public SelectElement Year
        {
            get
            {
                IWebElement yearDD = Driver.FindElement(By.Id("years"));
                return new SelectElement(yearDD);
            }
        }

        public IWebElement FirstNameAddress => Driver.FindElement(By.Id("firstname"));
        public IWebElement LastNameAddress => Driver.FindElement(By.Id("lastname"));
        public IWebElement Address => Driver.FindElement(By.Id("address1"));
        public IWebElement City => Driver.FindElement(By.Id("city"));
        public SelectElement State
        {
            get
            {
                IWebElement stateDD = Driver.FindElement(By.Id("id_state"));
                return new SelectElement(stateDD);
            }
        }
        public IWebElement ZipCode => Driver.FindElement(By.Id("postcode"));
      
        public IWebElement Phone => Driver.FindElement(By.Id("phone_mobile"));
        public IWebElement AddressAlias => Driver.FindElement(By.Id("alias"));
        public IWebElement RegisterButton => Driver.FindElement(By.XPath(@"//*[@id=""submitAccount""]"));

        public IWebElement ErrorMessage => Driver.FindElement(By.XPath("//*[@id='center_column']/div/ol/li[1]")); //na error съобщението като не напишеш правилно
      
      

       
    }
}
