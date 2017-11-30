using System;
using ChainReactionBindings.TestBase.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ChainReactionBindings.Bindings
{
	[Binding]
	class WishlistPageBindings
	{
		WishlistPage page = new WishlistPage();

		[Then(@"I see the wishlist page is loaded")]
		public void MainPageLoaded()
		{
			if (!page.WishlistPageLoaded())
			{
				throw new Exception("Main page is not loaded!");
			}
		}

		[Then(@"I see empty list of wishlist with message ""(.*)""")]
		public void ThenISeeEmptyListOfWishlist(string message)
		{
			Assert.AreEqual(message, page.EmptyWishlistElement.Text);
		}

		[Then(@"I see my wishlist with ""(.*)"" items")]
		public void SeeMyWishlistWithItems(string count)
		{
			Assert.AreEqual(count, page.CountItemsElement.Text);
		}

		[Then(@"I see ""(.*)"" wishlists")]
		public void SeeWishlistInListOfWishlist(int count)
		{
			Assert.AreEqual(count, page.GetWishlists());
		}

		[Then(@"I see ""(.*)"" items in wishlist with name ""(.*)""")]
		public void SeeItemsInWishlistWithName(string count, string name)
		{
			var countItems = page.GetCountItems(name);
			Assert.AreEqual(count, countItems.Text);
		}

		[When(@"I click View List button on wishlist with name ""(.*)""")]
		public void ClickViewListButtonOnWishlistWithName(string name)
		{
			page.ViewList(name);
		}

		[Then(@"I see details of goods in wishlist")]
		public void SeeDetailsOfGoodsInWishlist(Table table)
		{
			foreach (var row in table.Rows)
			{
				var fieldName = row["Details"];
				var fieldValue = row["Value"];
				switch (fieldName)
				{
					case "Title":
						Assert.AreEqual(fieldValue,page.GetItemTitle(fieldValue));
						break;
					case "Price":
						Assert.AreEqual(fieldValue, page.PriceElement.Text);
						break;
					default:
						throw new Exception(string.Format("Field {0} is not implemented", fieldName));
				}
			}
		}

		[When(@"I click Delete button on wishlist with name ""(.*)""")]
		public void ClickDeleteButtonOnWishlistWithName(string name)
		{
			page.DeleteWishlist(name);
		}

		[When(@"I click Confirm button")]
		public void WhenIClickConfirmButton()
		{
			page.ConfirmDelete();
		}

		[Then(@"I see empty wishlist with message ""(.*)""")]
		public void ThenISeeEmptyWishlist(string message)
		{
			Assert.AreEqual(message, page.EmptyWishlistElement.Text);
		}

		[Then(@"I see ""(.*)"" items in wishlist")]
		public void SeeItemsInWishlist(int count)
		{
			Assert.AreEqual(count, page.GetItemsFromWishlist());
		}

		[When(@"I click Remove button on item with name ""(.*)""")]
		public void ClickRemoveButtonOnItemWithName(string name)
		{
			page.RemoveItem(name);
		}

		[When(@"I enter quantity ""(.*)"" in first item and click Update button")]
		public void EnterQuantityInFirstItemAndClickUpdateButton(string count)
		{
			page.QuantityElement.Clear();
			page.QuantityElement.SendKeys(count);
			page.UpdateQuantities();
		}

		[Then(@"I see ""(.*)"" quantity")]
		public void SeeQuantity(string count)
		{
			Assert.AreEqual(count,page.QuantityElement.GetAttribute("value"));
		}

		[When(@"I click Add To Basket button for item ""(.*)"" on wishlist page")]
		public void ClickAddToBasketButtonForItemOnWishlistPage(string name)
		{
			page.AddToBasket(name);
		}

		[Then(@"I make sure that exist wishlist with name ""(.*)""")]
		public void MakeSureThatExistWishlistWithName(string name)
		{
			page.FindWishlist(name);
		}
	}
}
