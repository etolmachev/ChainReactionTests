using System;
using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	class SearchPage : BasePage
	{
		public string ViewLabelId = ".viewLabel";
		public string SearchResultId = "#search_page_title";
		public string ItemsCountId = ".grid_view_row";
		public string NotFoundMessageId = ".page_head";

		public HtmlElement ViewLabelElement;
		public HtmlElement ItemsCountElement;
		public HtmlElement SearchResultElement;
		public HtmlElement NotFoundMessageElement;

		public SearchPage()
		{
			ViewLabelElement = new HtmlElement(By.CssSelector(ViewLabelId));
			ItemsCountElement = new HtmlElement(By.CssSelector(ItemsCountId));
			SearchResultElement = new HtmlElement(By.CssSelector(SearchResultId));
			NotFoundMessageElement = new HtmlElement(By.CssSelector(NotFoundMessageId));
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
