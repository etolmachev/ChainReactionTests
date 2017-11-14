using System.Runtime.InteropServices;
using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	class WishlistPage: BasePage
	{
		public string WishlistHeaderId = ".user_profile_headding2";
		public string EmptyWishlistId = "div.wishlist_noitem_container p";
		public string CountItemsId = ".wishlist_col3";
		public string TableOfWishlistId = ".wishlist_container.mtb3";
		public string FindWishlistId = "//tr[./td/div/a[text()='{0}']]";
		public string ItemsTitleId = "h4";
		public string PriceId = ".fromamt";
		public string DeleteConfirmButtonId = "input[name='/atg/commerce/gifts/GiftlistFormHandler.deleteGiftlist']";

		public HtmlElement WishlistHeaderElement;
		public HtmlElement EmptyWishlistElement;
		public HtmlElement CountItemsElement;
		public HtmlElement TableOfWishlistElement;
		public HtmlElement ItemsTitleElement;
		public HtmlElement PriceElement;
		public HtmlElement DeleteConfirmElement;

		public WishlistPage()
		{
			WishlistHeaderElement = new HtmlElement(By.CssSelector(WishlistHeaderId));
			EmptyWishlistElement = new HtmlElement(By.CssSelector(EmptyWishlistId));
			CountItemsElement = new HtmlElement(By.CssSelector(CountItemsId));
			TableOfWishlistElement = new HtmlElement(By.CssSelector(TableOfWishlistId));
			ItemsTitleElement = new HtmlElement(By.CssSelector(ItemsTitleId));
			PriceElement = new HtmlElement(By.CssSelector(PriceId));
			DeleteConfirmElement = new HtmlElement(By.CssSelector(DeleteConfirmButtonId));
		}

		public bool WishlistPageLoaded()
		{
			return PageLoaded(WishlistHeaderElement);
		}

		public HtmlElement FindWishlist(string name)
		{
			var element = new HtmlElement(By.XPath(string.Format(FindWishlistId,name)));
			return element;
		}

		public void ViewList(IWebElement elem)
		{
			elem.Click();
		}

		public void DeleteWishlist(IWebElement elem)
		{
			elem.Click();
		}

		public void ConfirmDelete()
		{
			DeleteConfirmElement.Click();
		}
	}
}
