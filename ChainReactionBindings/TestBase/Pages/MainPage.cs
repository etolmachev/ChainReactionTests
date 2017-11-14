using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	public class MainPage : BasePage
	{
		public string BestSellersId = "div.crcBestSellersTitle";
		public string LogoutId = "#logout_id";
		public string InputTextId = "#auto_search";
		public string SearchButtonId = "input[name='/com/crc/search/formhandler/SearchFormHandler.textSearch']";
		public string WishlistButtonId = ".crcHeaderWishlist";

		public HtmlElement BestSellers;
		public HtmlElement LogoutElement;
		public HtmlElement InputTextElement;
		public HtmlElement SearchButtonElement;
		public HtmlElement WishlistButtonElement;

		public MainPage()
		{
			BestSellers = new HtmlElement(By.CssSelector(BestSellersId));
			LogoutElement = new HtmlElement(By.CssSelector(LogoutId));
			InputTextElement = new HtmlElement(By.CssSelector(InputTextId));
			SearchButtonElement = new HtmlElement(By.CssSelector(SearchButtonId));
			WishlistButtonElement = new HtmlElement(By.CssSelector(WishlistButtonId));
		}

		public bool MainPageLoaded()
		{
			return PageLoaded(BestSellers);
		}

		public void LogoutClick()
		{
			LogoutElement.Click();
		}
		public void SearchClick()
		{
			SearchButtonElement.Click();
		}
		public void WishlistClick()
		{
			WishlistButtonElement.Click();
		}
	}
}
