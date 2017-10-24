using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	public class MainPage
	{
		public string BestSellersId = "div.crcBestSellersTitle";

		public HtmlElement BestSellers;

		public MainPage()
		{
			BestSellers = new HtmlElement(By.CssSelector(BestSellersId));
		}

		public bool PageLoaded()
		{
			Browser.WaitReadyState();
			if (BestSellers.Displayed)
			{
				return true;
			}
			return false;
		}
	}
}
