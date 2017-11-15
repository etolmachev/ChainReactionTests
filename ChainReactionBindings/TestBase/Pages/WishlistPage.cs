using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	class WishlistPage: BasePage
	{
		private string WishlistHeaderId = ".user_profile_headding2";
		private string EmptyWishlistId = "div.wishlist_noitem_container p";
		private string CountItemsId = ".wishlist_col3";
		private string TableOfWishlistId = ".wishlist_container.mtb3";
		private string FindWishlistId = "//tr[./td/div/a[text()='{0}']]";
		private string ItemsTitleId = "h4";
		private string PriceId = ".fromamt";
		private string DeleteConfirmButtonId = "input[name='/atg/commerce/gifts/GiftlistFormHandler.deleteGiftlist']";

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

		public void ViewList(HtmlElement el)
		{
			var element = el.FindElement(By.ClassName("blue_btn2"));
			element.Click();
		}

		public void DeleteWishlist(HtmlElement el)
		{
			var element = el.FindElement(By.ClassName("wishlist_remove"));
			element.Click();
		}

		public void ConfirmDelete()
		{
			DeleteConfirmElement.Click();
		}
		public IWebElement GetViewButton(HtmlElement el)
		{
			var element = el.FindElement(By.ClassName("blue_btn2"));
			return element;
		}
		public IWebElement GetCountItems(HtmlElement el)
		{
			var element = el.FindElement(By.CssSelector(CountItemsId));
			return element;
		}
	}
}
