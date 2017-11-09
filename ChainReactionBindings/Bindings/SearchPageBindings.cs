using System;
using ChainReactionBindings.TestBase.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ChainReactionBindings.Bindings
{
	[Binding]
	class SearchPageBindings
	{
		SearchPage page = new SearchPage();

		[Then(@"I see the search page is loaded")]
		public void SearchPageLoaded()
		{
			if (!page.SearchPageLoaded())
			{
				throw new Exception("Search page is not loaded!");
			}
		}

		[Then(@"I see the empty search page is loaded")]
		public void EmptySearchPageLoaded()
		{
			if (!page.EmptySearchPageLoaded())
			{
				throw new Exception("Empty search page is not loaded!");
			}
		}

		[Then(@"I see ""(.*)"" message on search page for ""(.*)""")]
		public void ThenISeeMessageOnSearchPage(string text, string searchText)
		{
			string message = text + " results for " + searchText;
			if (text != "0")
			{
				Assert.AreEqual(message, page.SearchResultElement.Text);
			}
			else Assert.AreEqual(message, page.NotFoundMessageElement.Text);
		}

		[Then(@"I see ""(.*)"" message on search page")]
		public void ThenISeeMessageOnSearchPage(string text)
		{
			Assert.AreEqual(text.ToLower(), page.SearchResultElement.Text.ToLower());

		}

		[Then(@"I see ""(.*)"" on search page")]
		public void ThenISeeOnSearchPage(string text)
		{
			Assert.AreEqual(text, page.CategoryResultElement.Text);

		}
		[Then(@"I see ""(.*)"" items on search page")]
		public void ThenISeeItemsOnSearchPage(int count)
		{
			Assert.AreEqual(count, page.ItemsCountElement.FindElements(By.ClassName("products_details_container")).Count);
		}

		[Then(@"I see items name include ""(.*)""")]
		public void ThenISeeName(string text)
		{
			var itemsDesc = page.ItemsCountElement.FindElements(By.ClassName("description"));
			foreach (var item in itemsDesc)
			{
				Assert.IsTrue(item.Text.ToLower().Contains(text.ToLower()));
			}
		}

		[Then(@"I dont see items name include ""(.*)""")]
		public void ThenIDontSeeName(string text)
		{
			var itemsDesc = page.ItemsCountElement.FindElements(By.ClassName("description"));
			foreach (var item in itemsDesc)
			{
				Assert.IsFalse(item.Text.Contains(text));
			}
		}

		[When(@"I click on product with name ""(.*)"" from search results")]
		public void WhenIClickOnProductWithName(string name)
		{
			var allItems = page.ItemsCountElement.FindElements(By.ClassName("description"));
			foreach (var item in allItems)
			{
				if (item.Text.ToLower().Contains(name.ToLower()))
				{
					page.GoToDetails();
				}
			}
		}

	}
}
