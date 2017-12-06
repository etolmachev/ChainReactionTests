using System;
using ChainReactionBindings.TestBase;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChainReactionBindings.Bindings
{
	[Binding]
	class BasketPageBindings
	{
		BasketPage page = new BasketPage();

		[Then(@"I see the basket page is loaded")]
		public void MainPageLoaded()
		{
			if (!page.BasketPageLoaded())
			{
				throw new Exception("Main page is not loaded!");
			}
		}

		[Then(@"I make sure that basket is empty")]
		public void MakeSureThatBasketIsEmpty()
		{

			if (page.GetItems() != 0)
			{
				int count = page.GetItems();
				for (int i = count; i >= 1; i--)
				{
					page.RemoveItemBackground(i.ToString());
				}
			}

			Assert.IsTrue(page.MessageElement.Displayed);
		}

		[Then(@"I see the ""(.*)"" message on the basket page")]
		public void SeeTheMessageOnTheBasketPage(string message)
		{
			Assert.AreEqual(message, page.MessageElement.Text);
		}

		[Then(@"I see ""(.*)"" items in basket")]
		public void SeeItemsInBasket(int count)
		{
			Assert.AreEqual(count, page.GetItems());
		}

		[Then(@"I see following items in basket")]
		public void SeeFollowingItemsInBasket(Table table)
		{

			foreach (var row in table.Rows)
			{
				var fieldName = row["Name"];
				var fieldPrice = row["Price"];
				var fieldOption = row["Option"];
				var fieldQuantity = row["Quantity"];

				var el = page.GetItem(fieldName);

				Assert.AreEqual(fieldName, page.GetItemName(el));
				Assert.AreEqual(fieldPrice, page.GetItemPrice(el));
				Assert.AreEqual(fieldOption, page.GetItemOption(el));
				Assert.AreEqual(fieldQuantity, page.GetItemQuantity(el));
			}
		}

		[Then(@"I see ""(.*)"" subtotal cost on basket page")]
		public void SeeSubtotalCostOnBasketPAge(string subtotal)
		{
			Assert.AreEqual(subtotal, page.SubtotalElement.Text);
		}

		[When(@"I click Continue Shopping button on basket page")]
		public void ClickContinueShoppingButtonOnBasketPage()
		{
			page.ContinueShopping();
		}

		[When(@"I click Remove button on item in basket with name ""(.*)""")]
		public void ClickRemoveButtonOnItemInBasket(string name)
		{

			page.RemoveItem(name);
		}

		[Then(@"I don't see items in basket with name ""(.*)""")]
		public void DoNotSeeItemsInBasketWithName(string name)
		{
			Assert.IsFalse(page.GetItem(name).Displayed);
		}

		
	}
}
