using System;
using ChainReactionBindings.TestBase.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using System.Threading;

namespace ChainReactionBindings.Bindings
{
	[Binding]
	class WishlistPopupPageBindings
	{
		WishlistPopupPage page = new WishlistPopupPage();

		[Then(@"I see add to wishlist popup is loaded")]
		public void ThenISeeAddToWishlistPopupIsLoaded()
		{
			page.AddPopupElement.WaitElementAppears(10);
			Thread.Sleep(TimeSpan.FromSeconds(1));
		}

		[When(@"I choose first good and click Add To Wishlist button")]
		public void ChooseFirstGoodAndClickAddToWishlistButton()
		{
			page.AddToWishlistInPop();
		}

		[Then(@"I see select wishlist popup is loaded")]
		public void ThenISeeSelectWishlistPopupIsLoaded()
		{
			page.SelectPopElement.WaitElementAppears(10);
		}

		[When(@"I click Add To List button")]
		public void WhenIClickAddToListButton()
		{
			page.AddToList();
		}

		[Then(@"I see ""(.*)"" message on wishlist popup")]
		public void SeeMessageOnWishlistPopup(string message)
		{
			switch (message)
			{
				case "Please enter wish list name.":
					Assert.AreEqual(message, page.ErrorMessageElement.Text);
					break;
				case "Item added to wishlist":
					Assert.AreEqual(message, page.SuccessMessageElement.Text);
					break;
				default:
					throw new Exception(string.Format("Message {0} is not implemented", message));
			}
			
		}

		[When(@"I enter name of wishlist ""(.*)"" in the create text")]
		public void EnterNameOfWishlistInTheCreateText(string name)
		{
			page.NewWishlistNameElement.SendKeys(name);
		}

		[When(@"I click Create And Add To List button")]
		public void WhenIClickCreateAndAddToListButton()
		{
			page.CreateAndAddToList();
		}

		[Then(@"I click Close button")]
		public void WhenIClickCloseButton()
		{
			page.ClosePopup();
			Thread.Sleep(TimeSpan.FromSeconds(1));
		}

		[When(@"I select wishlist with name ""(.*)""")]
		public void SelectWishlistWithName(string wishlist)
		{
			page.MyWishlistElement = new SelectElement(page.SelectWishlistElement);
			page.MyWishlistElement.SelectByText(wishlist);
		}

		[When(@"I choose good with option ""(.*)"" and click Add To Wishlist button")]
		public void ChooseGoodWithOptionAndClickAddToWishlistButton(string option)
		{
			page.AddToWishlistInPop(option);
		}

	}
}
