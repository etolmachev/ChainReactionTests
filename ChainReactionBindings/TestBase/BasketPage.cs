using ChainReactionBindings.TestBase.Pages;
using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase
{
	class BasketPage: BasePage
	{
		private string TotalCostId = ".chk_tot2";

		public HtmlElement TotalCostElement;

		public BasketPage()
		{
			TotalCostElement = new HtmlElement(By.CssSelector(TotalCostId));
		}

		public bool BasketPageLoaded()
		{
			return PageLoaded(TotalCostElement);
		}
	}
}
