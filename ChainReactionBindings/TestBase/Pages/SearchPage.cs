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

		public HtmlElement ViewLabelElement;
		public HtmlElement ItemsCountElement;
		public HtmlElement SearchResultElement;
		public HtmlElement NotFoundMessageElement;
		public HtmlElement CategoryResultElement;

		public SearchPage()
		{
			ViewLabelElement = new HtmlElement(By.CssSelector(ViewLabelId));
			ItemsCountElement = new HtmlElement(By.CssSelector(ItemsCountId));
			SearchResultElement = new HtmlElement(By.CssSelector(SearchResultId));
			NotFoundMessageElement = new HtmlElement(By.CssSelector(NotFoundMessageId));
			CategoryResultElement = new HtmlElement(By.CssSelector(CategoryResultId));
		}

		public bool SearchPageLoaded()
		{
			return PageLoaded(ViewLabelElement);
		}
		public bool EmptySearchPageLoaded()
		{
			return PageLoaded(NotFoundMessageElement);
		}
	}
}
