using System;
using System.ComponentModel;
using ChainReactionBindings.TestBase;
using ChainReactionBindings.TestBase.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using System.Threading;

namespace ChainReactionBindings.Bindings
{
	[Binding]
	class ItemDetailsPageBindings
	{
		ItemDetailsPage page = new ItemDetailsPage();

		[Then(@"I see the product page for ""(.*)"" is loaded")]
		public void ThenISeeTheProductPage(string name)
		{
			page.ItemDetailsPageLoaded();
			Assert.AreEqual(name, page.ProductTitileElement.Text);
		}

		[Then(@"I see details on product page")]
		public void ThenISeeDetailsOnProductPage(Table table)
		{
			foreach (var row in table.Rows)
			{
				var fieldName = row["Details"];
				var fieldValue = row["Value"];
				switch (fieldName)
				{
					case "Price":
						Assert.AreEqual(fieldValue, page.PriceElement.Text);
						break;
					case "Rating":
						Assert.AreEqual(fieldValue, page.RatingElement.Text);
						break;
					case "Colour":
						Assert.AreEqual(fieldValue, page.ColourElement.Text);
						break;
					case "Wheel Size":
						Assert.AreEqual(fieldValue, page.WheelSizeElement.Text);
						break;
					case "Size":
						Assert.AreEqual(fieldValue, page.BottleSizeElement.Text);
						break;
					default:
						throw new Exception(string.Format("Field {0} is not implemented", fieldName));
				}
			}
		}

		[When(@"I select second option on product page")]
		public void WhenISelectOption()
		{
			page.ChangeOption();
		}

		[When(@"I select option ""(.*)"" on product page")]
		public void SelectOptionOnProductPage(string option)
		{
			page.ChangeOption(option);
		}

		[Then(@"I see new details on product page")]
		public void ThenISeeNewDetailsOnProductPage(Table table)
		{
			foreach (var row in table.Rows)
			{
				var fieldName = row["Details"];
				var fieldValue = row["Value"];
				switch (fieldName)
				{
					case "Frame Size":
						Assert.AreEqual(page.NewFrameSizeElement.Text, fieldValue);
						break;
					case "Colour":
						Assert.AreEqual(page.NewColourElement.Text, fieldValue);
						break;
					case "Size":
						Assert.AreEqual(page.NewSizeElement.Text, fieldValue);
						break;
					case "Width":
						Assert.AreEqual(page.NewFrameSizeElement.Text, fieldValue);
						break;
					default:
						throw new Exception(string.Format("Field {0} is not implemented", fieldName));
				}

			}
		}

		[When(@"I click on Read all reviews")]
		public void WhenIClickOnReadAllReviews()
		{
			page.SeeReviews();
			Thread.Sleep(TimeSpan.FromMilliseconds(500));
		}

		[When(@"I click on Empty Reviews")]
		public void WhenIClickOnReviews()
		{
			page.OpenEmptyReviews();
		}

		[Then(@"I see the following values in Ratings summary on product page")]
		public void WhenISeeTheFollowingValuesInRatingsSummaryOnProductPage(Table table)
		{
			foreach (var row in table.Rows)
			{
				var fieldName = row["Field"];
				var fieldValue = row["Value"];
				switch (fieldName)
				{
					case "Rating":
						Assert.AreEqual(fieldValue, page.RatingElement.Text);
						break;
					case "Reviews":
						Assert.AreEqual(fieldValue, page.CountReviewsElement.Text);
						break;
					default:
						throw new Exception(string.Format("Field {0} is not implemented", fieldName));
				}
			}
		}

		[When(@"I click Size Chart")]
		public void WhenIClickSizeChart()
		{
			page.OpenSizeChart();
		}

		[Then(@"I see chart is opened")]
		public void ThenISeeSizeChartIsOpened()
		{
			page.TopLogoElement.WaitElementAppears(30);
		}

		[When(@"I scroll to element")]
		public void ThenIScrollToElement()
		{
			var element = page.ContainerElement.FindElement(By.ClassName("crcPDPList"));
			Actions act = new Actions(Browser.Driver);
			act.MoveToElement(element);
			act.Perform();
		}

		[When(@"I scroll to name of product")]
		public void ThenIScrollToNameOfProduct()
		{
			var element = page.ContainerElement.FindElement(By.ClassName("crcPDPTitle"));
			Actions act = new Actions(Browser.Driver);
			act.MoveToElement(element);
			act.Perform();
		}

		[Then(@"I don't see Ratings summary on product page")]
		public void ThenIDoNotSeeRatingsSummary()
		{
			Assert.IsTrue(page.NoReviewsElement.Displayed);
		}

		[Then(@"I see Write A Review button")]
		public void ThenISeeWriteAReviewButton()
		{
			Assert.IsTrue(page.WriteReviewButtonElement.Displayed);
		}

		[When(@"I click Add To Wishlist button")]
		public void WhenIClickAddToWishlistButton()
		{
			page.AddToWishlist();
		}

		[When(@"I click Add To Basket button on item page")]
		public void ClickAddToBasketButtonOnItemPage()
		{
			page.AddToBasket();
			Thread.Sleep(TimeSpan.FromMilliseconds(500));
		}

		[When(@"I set ""(.*)"" as quantity on item page")]
		public void SetAsQuantityOnItemPage(int count)
		{
			for (int i = 1; i < count; i++)
			{
				page.PlusOne();
			}
		}

		[When(@"I close Size Chart")]
		public void CloseSizeChart()
		{
			page.CloseSizeChart();
		}

	}
}
