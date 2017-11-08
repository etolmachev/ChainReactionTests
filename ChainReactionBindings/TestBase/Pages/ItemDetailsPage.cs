using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	class ItemDetailsPage : BasePage
	{
		public string ProductTitleId = "li.crcPDPTitle";
		public string PriceId = "li.crcPDPPriceCurrent";
		public string RatingId = ".crcRatingOutOf5";
		public string ColourId = "div.crcPDPVariantColour span.crcPDPVariantLabelSelected";
		public string WheelSizeId = "div.crcPDPVariantDefault span.crcPDPVariantLabelSelected";
		public string BottleSizeId = ".crcPDPVariantLabelSelected";
		public string NewOptionId = "//div[@class='crcPDPVariantOption' and position()=2]";
		public string NewFrameSizeId = "//div[@class='crcPDPVariant crcPDPVariantDefault']/span[@class='crcPDPVariantLabelSelected']";
		public string NewColourId = "//div[@class='crcPDPVariant crcPDPVariantColour']/span[@class='crcPDPVariantLabelSelected']";
		public string NewSizeId = "//div[@class='crcPDPVariant crcPDPVariantSize']/span[@class='crcPDPVariantLabelSelected']";
		public string CustomerReviewsId = ".crcRatingReviewAll";
		public string CountReviewsId = "div#BVRRCustomNumReviews span.BVRRCount.BVRRNonZeroCount";
		public string SizeChartId = ".crcPDPVariantSizeGuide";
		public string TopLogoId = "#toplogo";
		public string ContainerId = ".pdpcontent_container";
		public string EmptyReviewsId = "#crcPDPBottomTabsReviewsLink";
		public string WriteReviewButtonId = "//div[@class='BVRRDisplayContentNoReviews']/a[@name='BV_TrackingTag_Review_Display_WriteReview']";

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
	}
}
