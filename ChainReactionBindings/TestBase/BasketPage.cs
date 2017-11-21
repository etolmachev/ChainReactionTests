using ChainReactionBindings.TestBase.Pages;
using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase
{
	class BasketPage: BasePage
	{
		private string TotalCostId = ".chk_tot2";
		private string MessageId = ".from1";

		public HtmlElement TotalCostElement;
		public HtmlElement MessageElement;

		public BasketPage()
		{
			TotalCostElement = new HtmlElement(By.CssSelector(TotalCostId));
			MessageElement = new HtmlElement(By.CssSelector(MessageId));
		}

		public bool BasketPageLoaded()
		{
			return PageLoaded(TotalCostElement);
		}
	}
}
