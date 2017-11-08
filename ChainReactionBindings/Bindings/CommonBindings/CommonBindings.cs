﻿using ChainReactionBindings.TestBase;
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
	}
}