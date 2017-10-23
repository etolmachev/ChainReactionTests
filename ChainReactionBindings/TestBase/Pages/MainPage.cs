using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	public class MainPage
	{
		public string BestSellersId = "div.crcBestSellersTitle";

		public IWebElement BestSellers;

		public MainPage()
		{
			BestSellers = Browser.Driver.FindElement(By.CssSelector(BestSellersId));
		}

		public bool PageLoaded()
		{
			if (BestSellers.Displayed)
			{
				return true;
			}
			return false;
		}
	}
}
