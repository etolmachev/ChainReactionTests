using OpenQA.Selenium;

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
