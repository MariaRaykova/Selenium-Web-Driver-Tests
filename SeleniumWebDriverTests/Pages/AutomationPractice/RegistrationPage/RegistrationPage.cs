using Framework;

namespace SeleniumWebDriverTests.Pages
{
    public partial class RegistrationPage
    {
        public void FillForm(RegistrationUser user)
        {
            RadioButtons[1].Click();
            CutomerFirstName.SendKeys(user.FirstName);
            CutomerLastName.SendKeys(user.LastName);
            CustomerPassword.SendKeys(user.Password);
            Date.SelectByValue(user.Date);
            Month.SelectByValue(user.Month);
            Year.SelectByValue(user.Year);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.SelectByText(user.State);
            ZipCode.SendKeys(user.PostCode);
            Phone.SendKeys(user.Phone);
            AddressAlias.SendKeys(user.Alias); //alias.Type("Maria") ???
            RegisterButton.Click();
        }

        public void Navigate(LoginPage loginPage)//за да можем да нацъкаме на първата страница нещата и да навигира до втората
        {
            var text = RandomGenerator.GenerateMail();

            loginPage.Navigate("http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation");

            loginPage.Email.SendKeys(text);
            loginPage.Submit.Click();
        }
    }
}
