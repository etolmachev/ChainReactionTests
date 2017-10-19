using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChainReactionBindings
{
    [Binding]
    public sealed class RegistrationStepDefinition
    {
        IWebDriver driver;
        [Given(@"I navigate to the page ""(.*)""")]
        public void GivenINavigateToThePage(string p0)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.chainreactioncycles.com/signin");
        }

        [Given(@"I see the page is loaded")]
        public void GivenISeeThePageIsLoaded()
        {
            Assert.AreEqual("Google",driver.Title);
        }

        [When(@"I click on CreateAnAccount Button")]
        public void WhenIClickOnCreateAnAccountButton()
        {
            driver.FindElement(By.ClassName("blue_btn")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        [Then(@"I go to the page ""(.*)""")]
        public void ThenIGoToThePage(string p0)
        {
            driver.Navigate().GoToUrl("https://www.chainreactioncycles.com/create-an-account");
        }

    }
}
