using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlow_Ava
{
    [Binding]
    public class GoogleSearchSteps
    {
		IWebDriver driver = new ChromeDriver();

        [Given(@"I am on the Google Home Page")]
        public void GivenIAmOnTheGoogleHomePage()
        {
			driver.Navigate().GoToUrl("https://www.google.co.nz/");
        }

		[Given(@"I have also entered '(.*)' on the search bar")]
		public void GivenIHaveAlsoEnteredOnTheSearchBar(string searchphrase)
		{
			driver.FindElement(By.Name("q")).SendKeys(searchphrase);
        }
        
        [When(@"I click the Google Search Button")]
        public void WhenIClickTheGoogleSearchButton()
        {
			driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
		}

		[Then(@"A new page should be shown with the page title '(.*)'")]
		public void ThenANewPageShouldBeShownWithThePageTitle(string searchphrase)
		{
			Assert.That(driver.Title, Is.EqualTo(searchphrase + " - Google Search"));
			driver.Close();		
		}
	}
}
