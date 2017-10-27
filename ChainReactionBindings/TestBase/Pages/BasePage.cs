namespace ChainReactionBindings.TestBase.Pages
{
	public class BasePage
	{
		public string root;

		public BasePage()
		{

		}

		public bool PageLoaded(HtmlElement element)
		{
			Browser.WaitReadyState();
			if (element.Displayed)
			{
				return true;
			}
			return false;
		}
	}
}
