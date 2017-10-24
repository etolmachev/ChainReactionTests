using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	public class TopMenu : BasePage
	{
		public string ShopByCategoryId = "li.shop_category";
		public string BrandsId = "li.searchmenu";
		public string SignInId = "li.signin_createact";
		public string RubRubId = "li.crcHeaderCountryCurrency";

		public HtmlElement ShopByCategoryElement;
		public HtmlElement BrandsElement;
		public HtmlElement SignInElement;
		public HtmlElement RubRubElement;

		public TopMenu()
		{
			ShopByCategoryElement = new HtmlElement(By.CssSelector(ShopByCategoryId));
			BrandsElement = new HtmlElement(By.CssSelector(BrandsId));
			SignInElement = new HtmlElement(By.CssSelector(SignInId));
			RubRubElement = new HtmlElement(By.CssSelector(RubRubId));
		}

		//public bool PageLoaded()
		//{
		//	if (BrandsElement.Displayed)
		//	{
		//		return true;
		//	}
		//	return false;
		//}

		public void ClickSignIn()
		{
			SignInElement.Click();
		}

		public void OpenRub()
		{
			RubRubElement.Click();
		}
	}
}
