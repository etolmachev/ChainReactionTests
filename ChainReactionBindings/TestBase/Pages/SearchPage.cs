using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ChainReactionBindings.TestBase.Pages
{
	class SearchPage : BasePage
	{
		private string ViewLabelId = ".viewLabel";
		private string SearchResultId = "#search_page_title";
		private string ItemsCountId = "#grid-view";
		private string NotFoundMessageId = ".page_head";
		private string CategoryResultId = ".page_heading";
		private string ProductDescriptionId = "li.description";
		private string SelectOptionId = ".selectboxit-text";
		private string BuyButtonId = ".widget_active_btn";
		private string GenderId = "//ul[@class='brand_list']/li/a[contains(.,'{0}')]";
		private string LeftMenuId = ".left_nav";
		private string BrandId = "//ul[@class='brand_list show-more-less']/li/a/span[contains(text(), '{0}')]";
		private string ColourId = "//ul[@class='brand_list']/li/a[@title='{0}']";
		private string FromId = "#pf";
		private string ToId = "#pt";
		private string GoButtonId = ".priceFilterRef";
		private string NoResultsFilterMessageId = ".no_results_message";
		private string OptionId = "//li[@class='refine_filter_result_label' and span[contains(.,'{0}')]]";

		public HtmlElement ViewLabelElement;
		public HtmlElement ItemsCountElement;
		public HtmlElement SearchResultElement;
		public HtmlElement NotFoundMessageElement;
		public HtmlElement CategoryResultElement;
		public HtmlElement ProductDescriptionElement;
		public HtmlElement SelectOptionElement;
		public HtmlElement BuyButtonElement;
		public HtmlElement LeftMenuElement;
		public HtmlElement FromElement;
		public HtmlElement ToElement;
		public HtmlElement GoButtonElement;
		public HtmlElement NoResultsFilterMessageElement;

		public SearchPage()
		{
			ViewLabelElement = new HtmlElement(By.CssSelector(ViewLabelId));
			ItemsCountElement = new HtmlElement(By.CssSelector(ItemsCountId));
			SearchResultElement = new HtmlElement(By.CssSelector(SearchResultId));
			NotFoundMessageElement = new HtmlElement(By.CssSelector(NotFoundMessageId));
			CategoryResultElement = new HtmlElement(By.CssSelector(CategoryResultId));
			ProductDescriptionElement = new HtmlElement(By.CssSelector(ProductDescriptionId));
			SelectOptionElement = new HtmlElement(By.CssSelector(SelectOptionId));
			BuyButtonElement = new HtmlElement(By.CssSelector(BuyButtonId));
			LeftMenuElement = new HtmlElement(By.CssSelector(LeftMenuId));
			FromElement = new HtmlElement(By.CssSelector(FromId));
			ToElement = new HtmlElement(By.CssSelector(ToId));
			GoButtonElement = new HtmlElement(By.CssSelector(GoButtonId));
			NoResultsFilterMessageElement = new HtmlElement(By.CssSelector(NoResultsFilterMessageId));
		}

		public bool SearchPageLoaded()
		{
			return PageLoaded(ViewLabelElement);
		}
		public bool EmptySearchPageLoaded()
		{
			return PageLoaded(NotFoundMessageElement);
		}
		public void GoToDetails()
		{
			ProductDescriptionElement.Click();
		}
		public void OpenSelect()
		{
			SelectOptionElement.Click();
		}
		public void Buy()
		{
			BuyButtonElement.Click();
		}
		public void GenderClick(string gender)
		{
			var element = LeftMenuElement.FindElement(By.XPath(string.Format(ColourId, "Black")));
			Actions act = new Actions(Browser.Driver);
			act.MoveToElement(element);
			act.Perform();
			LeftMenuElement.FindElement(By.XPath(string.Format(GenderId, gender))).Click();
		}
		public void BrandClick(string brand)
		{
			LeftMenuElement.FindElement(By.XPath(string.Format(BrandId, brand))).Click();
		}
		public void ColourClick(string colour)
		{
			var element = LeftMenuElement.FindElement(By.XPath(string.Format(ColourId, colour)));
			Actions act = new Actions(Browser.Driver);
			act.MoveToElement(element);
			act.Perform();
			element.Click();
		}
		public void DeletePrice()
		{
			LeftMenuElement.FindElement(By.XPath("//ul[@class='your_choices']/li[contains(., 'RUB')]")).Click();
		}
		public void DeleteColour()
		{
			var el = LeftMenuElement.FindElement(By.XPath("//li[@class='refine_filter_result_label' and ./span/div]"));
			el.FindElement(By.TagName("a")).Click();
		}
		public void DeleteOption(string option)
		{
			var el = LeftMenuElement.FindElement(By.XPath(string.Format(OptionId, option)));
			el.FindElement(By.TagName("a")).Click();
		}
		public int GetCountItems()
		{
			return ItemsCountElement.FindElements(By.ClassName("products_details_container")).Count;
		}
		public void SetPrice(string from, string to)
		{
			FromElement.SendKeys(from);
			ToElement.SendKeys(to);
			GoButtonElement.Click();
		}
	}
}
