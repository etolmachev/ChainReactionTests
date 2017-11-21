using System;
using ChainReactionBindings.TestBase;
using TechTalk.SpecFlow;

namespace ChainReactionBindings.Bindings
{
	[Binding]
	class BasketPageBindings
	{
		BasketPage page = new BasketPage();

		[Then(@"I see the basket page is loaded")]
		public void MainPageLoaded()
		{
			if (!page.BasketPageLoaded())
			{
				throw new Exception("Main page is not loaded!");
			}
		}

	}
}
