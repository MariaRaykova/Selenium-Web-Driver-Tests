using OpenQA.Selenium;

namespace SeleniumWebDriverTests.Extentions
{
    static class ElementExtention //не го използваме до сега
    {
        public static void Type (this IWebElement element, string value) 
        {
            element.Clear();
            element.SendKeys(value);
        }
    }
}
