using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ChainReactionBindings.TestBase.Pages
{
	class WishlistPopupPage : BasePage
	{
		private string AddPopupId = ".addto_wishlist_pop.addcart";
		private string AddToWishlistInPopId = ".email_alert";
		private string SelectPopId = ".addtoWishlist";
		private string AddToListButtonId = "input[value='Add to List']";
		private string ErrorMessageId = "span[style='color: red']";
		private string NewWishlistNameId = "input[name='/atg/commerce/gifts/GiftlistFormHandler.eventName']";
		private string CreateAndAddToListButtonId = "input[value='Create & Add to List']";
		private string SuccessMessageId = ".suc_msg";
		private string CloseButtonId = ".blue_btn.cancel";
		private string SelectWishlistId = "select[name='/atg/commerce/gifts/GiftlistFormHandler.giftlistId'";

		public HtmlElement AddPopupElement;
		public HtmlElement AddToWishlistInPopElement;
		public HtmlElement SelectPopElement;
		public HtmlElement AddToListButtonElement;
		public HtmlElement ErrorMessageElement;
		public HtmlElement NewWishlistNameElement;
		public HtmlElement CreateAndAddToListButtonElement;
		public HtmlElement SuccessMessageElement;
		public HtmlElement CloseButtonElement;
		public HtmlElement SelectWishlistElement;
		public SelectElement MyWishlistElement;

		public WishlistPopupPage()
		{
			AddPopupElement = new HtmlElement(By.CssSelector(AddPopupId));
			AddToWishlistInPopElement = new HtmlElement(By.CssSelector(AddToWishlistInPopId));
			SelectPopElement = new HtmlElement(By.CssSelector(SelectPopId));
			AddToListButtonElement = new HtmlElement(By.CssSelector(AddToListButtonId));
			ErrorMessageElement = new HtmlElement(By.CssSelector(ErrorMessageId));
			NewWishlistNameElement = new HtmlElement(By.CssSelector(NewWishlistNameId));
			CreateAndAddToListButtonElement = new HtmlElement(By.CssSelector(CreateAndAddToListButtonId));
			SuccessMessageElement = new HtmlElement(By.CssSelector(SuccessMessageId));
			CloseButtonElement = new HtmlElement(By.CssSelector(CloseButtonId));
			SelectWishlistElement = new HtmlElement(By.CssSelector(SelectWishlistId));
		}

		public bool WishlistPopupPageLoaded()
		{
			return PageLoaded(AddPopupElement);
		}
		public void AddToWishlistInPop()
		{
			AddToWishlistInPopElement.Click();
		}
		public void AddToList()
		{
			AddToListButtonElement.Click();
		}
		public void CreateAndAddToList()
		{
			CreateAndAddToListButtonElement.Click();
		}
		public void ClosePopup()
		{
			CloseButtonElement.Click();
		}
	}
}
