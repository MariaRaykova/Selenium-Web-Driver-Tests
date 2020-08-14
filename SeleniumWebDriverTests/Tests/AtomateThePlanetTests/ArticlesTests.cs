using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebDriverTest.Pages.AutomateThePlanet;

namespace SeleniumWebDriverTests.Tests.AtomateThePlanetTests
{
    [TestFixture]
    public class ArticlesTests : BaseTest
    {
        private HomePage _automateThePanetHomePage;
        private BlogPage _blogPage;
        private ArticlePage _articlePage;
        public ArticlesTests(IWebDriver driver) 
            : base(driver)
        {
        }

        [Test]
        public void AutomateThePlanet()
        {
            _automateThePanetHomePage = new Pages.AutomateThePlanet.HomePage(Driver);
            _blogPage = new BlogPage(_driver);
            _articlePage = new ArticlePage(_driver);

            _driver.Url = "https://www.automatetheplanet.com/";

            _automateThePanetHomePage.BlogButton.Click();
            _blogPage.Articles[5].Click();

            for (int i = 0; i < _articlePage.NavigationMainTitles.Count; i++)
            {
                Thread.Sleep(1000); //ama to pak ne znam dali stana,maj ne
                _articlePage.ScrollTo(_articlePage.QickNavigaion);
                _articlePage.Scroll(200); //scroll-нахме 200 пиксела нагоре, за да може да стигнем до главните в навигейшъна

                var text = _articlePage.NavigationMainTitles[i].Text; //ama tochno tuk li trqbwa da e....

                _articlePage.NavigationMainTitles[i].Click();
                Assert.IsTrue(_articlePage.MainHeader[i].Displayed);
            }

            var navigationTitles = _articlePage.NavigationMainTitles.Select(e => e.Text).ToList(); //взимаме текста на  вс елементи вътре в колекциите (от менюто и от текста в таговете). Като вземем тези елементи ще ги  сравним
            var titles = _articlePage.MainHeader.Select(e => e.Text).ToList();

            CollectionAssert.AreEqual(navigationTitles, titles);

            var navigationSecondaryTitles = _articlePage.NavigationSecondaryTitles.Select(e => e.Text).ToList();
            var secondaryTitles = _articlePage.SecondaryHeader.Select(e => e.Text).ToList();

            CollectionAssert.AreEqual(navigationSecondaryTitles, secondaryTitles);
        }
    }
}
