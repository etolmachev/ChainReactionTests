using System;
using System.Runtime.InteropServices;
using ChainReactionBindings.TestBase;
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

		[Then(@"I see ""(.*)"" wishlist in list of wishilist")]
		public void SeeWishlistInListOfWishlist(int count)
		{
			Assert.AreEqual(count, page.TableOfWishlistElement.FindElements(By.ClassName("wishlist_col2")).Count);
		}

		[Then(@"I see ""(.*)"" items in wishlist with name ""(.*)""")]
		public void SeeItemsInWishlistWithName(string count, string name)
		{
			var el = page.FindWishlist(name);
			var countItems = el.FindElement(By.CssSelector(page.CountItemsId));
			Assert.AreEqual(count, countItems.Text);
		}

		[When(@"I click View List button on wishlist with name ""(.*)""")]
		public void ClickViewListButtonOnWishlistWithName(string name)
		{
			var el = page.FindWishlist(name);
			var viewButton = el.FindElement(By.ClassName("blue_btn2"));
			page.ViewList(viewButton);
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
						Assert.AreEqual(fieldValue,page.ItemsTitleElement.Text);
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
			var el = page.FindWishlist(name);
			var deleteWishlist = el.FindElement(By.ClassName("wishlist_remove"));
			page.DeleteWishlist(deleteWishlist);
		}

		[When(@"I click Confirm button")]
		public void WhenIClickConfirmButton()
		{
			page.ConfirmDelete();
		}
	}
}
