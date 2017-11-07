using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	class SearchPage : BasePage
	{
		public string ViewLabelId = ".viewLabel";
		public string SearchResultId = "#search_page_title";
		public string ItemsCountId = "#grid-view";
		public string NotFoundMessageId = ".page_head";
		public string CategoryResultId = ".page_heading";
		public string ProductDescriptionId = "li.description";

		public HtmlElement ViewLabelElement;
		public HtmlElement ItemsCountElement;
		public HtmlElement SearchResultElement;
		public HtmlElement NotFoundMessageElement;
		public HtmlElement CategoryResultElement;
		public HtmlElement ProductDescriptionElement;

		public SearchPage()
		{
			ViewLabelElement = new HtmlElement(By.CssSelector(ViewLabelId));
			ItemsCountElement = new HtmlElement(By.CssSelector(ItemsCountId));
			SearchResultElement = new HtmlElement(By.CssSelector(SearchResultId));
			NotFoundMessageElement = new HtmlElement(By.CssSelector(NotFoundMessageId));
			CategoryResultElement = new HtmlElement(By.CssSelector(CategoryResultId));
			ProductDescriptionElement = new HtmlElement(By.CssSelector(ProductDescriptionId));
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
	}
}
