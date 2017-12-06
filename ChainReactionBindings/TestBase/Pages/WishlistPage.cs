using System.CodeDom;
using System.Collections.Generic;
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
		private string WishlistContainerId = ".wishlist_container";
		private string FindItemId = "//div[@class='wishlist_product_container' and ./div/ul/li/a/h4[text()='{0}']]";
		private string QuantityId = ".wishlist_qty_desired input";
		private string UpdateQuantitiesId = "input[name='/atg/commerce/gifts/GiftlistFormHandler.updateGiftlistItems'";

		public HtmlElement WishlistHeaderElement;
		public HtmlElement EmptyWishlistElement;
		public HtmlElement CountItemsElement;
		public HtmlElement TableOfWishlistElement;
		public HtmlElement ItemsTitleElement;
		public HtmlElement PriceElement;
		public HtmlElement DeleteConfirmElement;
		public HtmlElement WishlistContainerElement;
		public HtmlElement QuantityElement;
		public HtmlElement UpdateQuantitiesElement;

		public WishlistPage()
		{
			WishlistHeaderElement = new HtmlElement(By.CssSelector(WishlistHeaderId));
			EmptyWishlistElement = new HtmlElement(By.CssSelector(EmptyWishlistId));
			CountItemsElement = new HtmlElement(By.CssSelector(CountItemsId));
			TableOfWishlistElement = new HtmlElement(By.CssSelector(TableOfWishlistId));
			ItemsTitleElement = new HtmlElement(By.CssSelector(ItemsTitleId));
			PriceElement = new HtmlElement(By.CssSelector(PriceId));
			DeleteConfirmElement = new HtmlElement(By.CssSelector(DeleteConfirmButtonId));
			WishlistContainerElement = new HtmlElement(By.CssSelector(WishlistContainerId));
			QuantityElement = new HtmlElement(By.CssSelector(QuantityId));
			UpdateQuantitiesElement = new HtmlElement(By.CssSelector(UpdateQuantitiesId));
		}

		public bool WishlistPageLoaded()
		{
			return PageLoaded(WishlistHeaderElement);
		}

		public void ViewList(string name)
		{
			var el = new HtmlElement(By.XPath(string.Format(FindWishlistId, name)));
			var element = el.FindElement(By.ClassName("blue_btn2"));
			element.Click();
		}

		public void DeleteWishlist(string name)
		{
			var el = new HtmlElement(By.XPath(string.Format(FindWishlistId, name)));
			var element = el.FindElement(By.ClassName("wishlist_remove"));
			element.Click();
		}

		public void ConfirmDelete()
		{
			DeleteConfirmElement.Click();
		}
		public IWebElement GetViewButton(HtmlElement el)
		{
			return el.FindElement(By.ClassName("blue_btn2"));
		}
		public IWebElement GetCountItems(string name)
		{
			var el = new HtmlElement(By.XPath(string.Format(FindWishlistId, name)));
			return el.FindElement(By.CssSelector(CountItemsId));
		}

		public void RemoveItem(string name)
		{
			var el = new HtmlElement(By.XPath(string.Format(FindItemId, name)));
			var element = el.FindElement(By.ClassName("remove_wishlist1"));
			element.Click();
		}

		public void UpdateQuantities()
		{
			UpdateQuantitiesElement.Click();
		}

		public int GetItemsFromWishlist()
		{
			return WishlistContainerElement.FindElements(By.ClassName("wishlist_product_container")).Count;
		}
		public int GetWishlists()
		{
			return TableOfWishlistElement.FindElements(By.ClassName("wishlist_col2")).Count;
		}
		public void AddToBasket(string name)
		{
			var el = new HtmlElement(By.XPath(string.Format(FindItemId, name)));
			var element = el.FindElement(By.ClassName("blue_btn_add"));
			element.Click();
		}

		public void FindWishlist(string name)
		{
			var el = new HtmlElement(By.XPath(string.Format(FindWishlistId, name)));
		}

		public string GetItemTitle(string name)
		{
			var el = new HtmlElement(By.XPath(string.Format(FindItemId, name)));
			return el.FindElement(By.CssSelector(ItemsTitleId)).Text;
		}

		public void RemoveItemBackground()
		{
			WishlistContainerElement.FindElement(By.XPath("//div[@class='wishlist_product_col3']/ul/form/li/a/span")).Click();
		}
	}
}
