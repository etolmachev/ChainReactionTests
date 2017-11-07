using System;
using System.Threading;
using ChainReactionBindings.TestBase;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace ChainReactionBindings.CommonBindings
{
	[Binding]
	public class CommonBindings
	{
		[Given(@"I open browser")]
		public void IOpenBrowser()
		{
			if (!Browser.IsInitialized)
			{
				Browser.BuildBrowser();
				Browser.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
			}
		}

		[When(@"I navigate to the page ""(.*)""")]
		public void GivenINavigateToThePage(string url)
		{
			Browser.Driver.Navigate().GoToUrl(url);
		}

		[When(@"I add ""(.*)"" value with ""(.*)"" key to Scenario Context")]
		public void AddToScenarioContext(string value, string key)
		{
			ScenarioContext.Current.Add(Utils.ResolveExpression(key), Utils.ResolveExpression(value));
		}

		[Then(@"I wait for ""(.*)"" seconds")]
		public void ThenIWaitForSeconds(int seconds)
		{
			Thread.Sleep(TimeSpan.FromSeconds(seconds));
		}

	}
}