using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace ChainReactionBindings.TestBase.Pages
{
	class ItemDetailsPage : BasePage
	{
		private string ProductTitleId = "li.crcPDPTitle";
		private string PriceId = "li.crcPDPPriceCurrent";
		private string RatingId = ".crcRatingOutOf5";
		private string ColourId = "div.crcPDPVariantColour span.crcPDPVariantLabelSelected";
		private string WheelSizeId = "div.crcPDPVariantDefault span.crcPDPVariantLabelSelected";
		private string BottleSizeId = ".crcPDPVariantLabelSelected";
		private string NewOptionId = "//div[@class='crcPDPVariantOption' and position()=2]";
		private string NewFrameSizeId = "//div[@class='crcPDPVariant crcPDPVariantDefault']/span[@class='crcPDPVariantLabelSelected']";
		private string NewColourId = "//div[@class='crcPDPVariant crcPDPVariantColour']/span[@class='crcPDPVariantLabelSelected']";
		private string NewSizeId = "//div[@class='crcPDPVariant crcPDPVariantSize']/span[@class='crcPDPVariantLabelSelected']";
		private string CustomerReviewsId = ".crcRatingReviewAll";
		private string CountReviewsId = "div#BVRRCustomNumReviews span.BVRRCount.BVRRNonZeroCount";
		private string SizeChartId = ".crcPDPVariantSizeGuide";
		private string TopLogoId = "#toplogo";
		private string ContainerId = ".pdpcontent_container";
		private string EmptyReviewsId = "#crcPDPBottomTabsReviewsLink";
		private string WriteReviewButtonId = "//div[@class='BVRRDisplayContentNoReviews']/a[@name='BV_TrackingTag_Review_Display_WriteReview']";
		private string NoReviewsId = "#BVRRDisplayContentNoReviewsID";
		private string AddToWishlistButtonId = ".crcLoggedIn";
		private string AddToBasketButtonId = ".crcButtonIconBasket";
		private string PlusButtonId = ".plus.active";
		private string FindOptionId = "//div[@class='crcPDPVariantOption' and @data-value='{0}']";
		private string OptionContentId = ".crcPDPVariants";
		private string CloseSizeChartButtonId = "#fancybox-close";

		public HtmlElement ProductTitileElement;
		public HtmlElement PriceElement;
		public HtmlElement RatingElement;
		public HtmlElement ColourElement;
		public HtmlElement WheelSizeElement;
		public HtmlElement BottleSizeElement;
		public HtmlElement NemOptionElement;
		public HtmlElement NewFrameSizeElement;
		public HtmlElement CustomerReviewsElement;
		public HtmlElement CountReviewsElement;
		public HtmlElement SizeChartElement;
		public HtmlElement TopLogoElement;
		public HtmlElement ContainerElement;
		public HtmlElement EmptyReviewsElement;
		public HtmlElement WriteReviewButtonElement;
		public HtmlElement NewColourElement;
		public HtmlElement NewSizeElement;
		public HtmlElement NoReviewsElement;
		public HtmlElement AddToWishlistButtonElement;
		public HtmlElement AddToBasketButtonElement;
		public HtmlElement PlusButtonElement;
		public HtmlElement OptionContentElement;
		public HtmlElement CloseSizeChartButtonElement;

		public ItemDetailsPage()
		{
			ProductTitileElement = new HtmlElement(By.CssSelector(ProductTitleId));
			PriceElement = new HtmlElement(By.CssSelector(PriceId));
			RatingElement = new HtmlElement(By.CssSelector(RatingId));
			ColourElement = new HtmlElement(By.CssSelector(ColourId));
			WheelSizeElement = new HtmlElement(By.CssSelector(WheelSizeId));
			BottleSizeElement = new HtmlElement(By.CssSelector(BottleSizeId));
			NemOptionElement = new HtmlElement(By.XPath(NewOptionId));
			NewFrameSizeElement = new HtmlElement(By.XPath(NewFrameSizeId));
			CustomerReviewsElement = new HtmlElement(By.CssSelector(CustomerReviewsId));
			SizeChartElement = new HtmlElement(By.CssSelector(SizeChartId));
			ContainerElement = new HtmlElement(By.CssSelector(ContainerId));
			EmptyReviewsElement = new HtmlElement(By.CssSelector(EmptyReviewsId));
			NewColourElement = new HtmlElement(By.XPath(NewColourId));
			NewSizeElement = new HtmlElement(By.XPath(NewSizeId));
			TopLogoElement = new HtmlElement(By.CssSelector(TopLogoId));
			CountReviewsElement = new HtmlElement(By.CssSelector(CountReviewsId));
			NoReviewsElement = new HtmlElement(By.CssSelector(NoReviewsId));
			WriteReviewButtonElement = new HtmlElement(By.XPath(WriteReviewButtonId));
			AddToWishlistButtonElement = new HtmlElement(By.CssSelector(AddToWishlistButtonId));
			AddToBasketButtonElement = new HtmlElement(By.CssSelector(AddToBasketButtonId));
			PlusButtonElement = new HtmlElement(By.CssSelector(PlusButtonId));
			OptionContentElement = new HtmlElement(By.CssSelector(OptionContentId));
			CloseSizeChartButtonElement = new HtmlElement(By.CssSelector(CloseSizeChartButtonId));

		}
		public bool ItemDetailsPageLoaded()
		{
			return PageLoaded(ProductTitileElement);
		}

		public void ChangeOption()
		{
			NemOptionElement.Click();
		}

		public void SeeReviews()
		{
			CustomerReviewsElement.Click();
		}

		public void OpenSizeChart()
		{
			SizeChartElement.Click();
		}

		public void OpenEmptyReviews()
		{
			EmptyReviewsElement.Click();
		}

		public void AddToWishlist()
		{
			AddToWishlistButtonElement.Click();
		}

		public void AddToBasket()
		{
			AddToBasketButtonElement.Click();
		}
		public void PlusOne()
		{
			PlusButtonElement.Click();
		}
		public void ChangeOption(string option)
		{
			var el = OptionContentElement.FindElement(By.XPath(string.Format(FindOptionId, option)));
			el.Click();
		}

		public void CloseSizeChart()
		{
			CloseSizeChartButtonElement.Click();
		}

		public void ScrollToElement()
		{
			var element = ContainerElement.FindElement(By.ClassName("crcPDPList"));
			Actions act = new Actions(Browser.Driver);
			act.MoveToElement(element);
			act.Perform();
		}

		public void ScrollToNameOfProduct()
		{
			var element = ContainerElement.FindElement(By.ClassName("crcPDPTitle"));
			Actions act = new Actions(Browser.Driver);
			act.MoveToElement(element);
			act.Perform();
		}
	}
}
