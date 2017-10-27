using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	public class MainPage : BasePage
	{
		public string BestSellersId = "div.crcBestSellersTitle";
		public string LogoutId = "#logout_id";

		public HtmlElement BestSellers;
		public HtmlElement LogoutElement;

		public MainPage()
		{
			BestSellers = new HtmlElement(By.CssSelector(BestSellersId));
			LogoutElement = new HtmlElement(By.CssSelector(LogoutId));
		}

		/*public bool PageLoaded()
		{
			Browser.WaitReadyState();
			if (BestSellers.Displayed)
			{
				return true;
			}
			return false;
		}*/
		public bool MainPageLoaded()
		{
			return PageLoaded(BestSellers);
		}

		public void LogoutClick()
		{
			LogoutElement.Click();
		}
	}
}
