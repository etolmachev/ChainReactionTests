using ChainReactionBindings.TestBase;
using ChainReactionBindings.TestBase.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace ChainReactionBindings.Bindings.TopMenuBindings
{
	[Binding]
	public class TopMenuBindings
	{
		public TopMenu page = new TopMenu();

		[When(@"I click on Sign In on top menu")]
		public void WhenIClickOnSignInOnTopMenu()
		{
			page.ClickSignIn();
		}

		[When(@"I click on RubRub dropdown and I select language")]
		public void WhenIClickOnRubRubDropdown()
		{
			page.OpenRub();
			page.SelectLanguageElement = new HtmlElement(By.CssSelector(page.SelectLanguageId));
			page.EnglishLanguagElement = new SelectElement(page.SelectLanguageElement);
			page.EnglishLanguagElement.SelectByValue("en");
		}

		[When(@"I click Update button")]
		public void ClickUpdateButton()
		{
			page.UpdateButtonElement = new HtmlElement(By.CssSelector(page.UpdateButtonId));
			page.Update();
		}
		[When(@"I click Wishlist button on Top menu")]
		public void WhenIClickWishlistButton()
		{
			page.OpenWishlist();
		}

		[When(@"I click Basket button")]
		public void ClickBasketButton()
		{
			page.OpenBasket();
		}

	}
}
