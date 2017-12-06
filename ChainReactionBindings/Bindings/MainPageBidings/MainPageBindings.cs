using System;
using ChainReactionBindings.TestBase.Pages;
using TechTalk.SpecFlow;

namespace ChainReactionBindings.Bindings.MainPageBidings
{
	[Binding]
	public class MainPageBindings
	{
		MainPage page = new MainPage();

		[Then(@"I see the main page is loaded")]
		public void MainPageLoaded()
		{
			if (!page.MainPageLoaded())
			{
				throw new Exception("Main page is not loaded!");
			}
		}

		[When(@"I click Logout button")]
		public void WhenIClickLogoutButton()
		{
			page.LogoutClick();
		}

		[When(@"I enter ""(.*)"" in the search text")]
		public void WhenIEnterSearchKeywordInTheSearchText(string text)
		{
			page.InputTextElement.Clear();
			page.InputTextElement.SendKeys(text);
		}

		[When(@"I click Search button")]
		public void WhenIClickSearchButton()
		{
			page.SearchClick();
		}

	}
}
