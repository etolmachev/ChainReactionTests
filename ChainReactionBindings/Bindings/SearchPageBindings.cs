using System;
using System.Collections.Generic;
using System.Linq;
using ChainReactionBindings.TestBase;
using ChainReactionBindings.TestBase.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecRun.SpecFlowPlugin.Generator;

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

		[Then(@"I see ""(.*)"" message on search page")]
		public void ThenISeeMessageOnSearchPage(string text)
		{
			switch (text)
			{
				case "1183 results for 'bike'":
					Assert.AreEqual(text, page.SearchResultElement.Text);
					break;
				case "0 results for \"auto and shirt\"":
					Assert.AreEqual(text, page.NotFoundMessageElement.Text);
					break;
				default:
					throw new Exception(string.Format("Field {0} is not implemented", text));
			}
			
		}

		[Then(@"I see ""(.*)"" items on search page")]
		public void ThenISeeItemsOnSearchPage(string count)
		{
			Assert.AreEqual(count, page.ItemsCountElement.FindElements(By.ClassName("products_details_container")).Count.ToString());
		}

		[Then(@"I see items name include ""(.*)""")]
		public void ThenISeeName(string text)
		{
			var itemsDesc = page.ItemsCountElement.FindElements(By.ClassName("description"));
			foreach (var item in itemsDesc)
			{
				Assert.IsTrue(item.Text.Contains(text));
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
	}
}
