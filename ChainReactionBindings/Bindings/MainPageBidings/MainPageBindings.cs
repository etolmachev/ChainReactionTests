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
			if (!page.PageLoaded())
			{
				throw new Exception("Main page is not loaded!");
			}
		}

		[When(@"I click Logout button")]
		public void WhenIClickLogoutButton()
		{
			page.LogoutClick();
		}
	}
}
