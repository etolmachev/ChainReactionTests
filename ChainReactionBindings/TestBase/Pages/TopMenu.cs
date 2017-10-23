using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	public class TopMenu : BasePage
	{
		public string ShopByCategoryId = "li.shop_category";
		public string BrandsId = "li.searchmenu";
		public string SignInId = "li.signin_createact";
		public string RubRubId = "li.crcHeaderCountryCurrency";

		public IWebElement ShopByCategoryElement;
		public IWebElement BrandsElement;
		public IWebElement SignInElement;
		public IWebElement RubRubElement;

		public TopMenu()
		{
			ShopByCategoryElement = Browser.Driver.FindElement(By.CssSelector(ShopByCategoryId));
			BrandsElement = Browser.Driver.FindElement(By.CssSelector(BrandsId));
			SignInElement = Browser.Driver.FindElement(By.CssSelector(SignInId));
			RubRubElement = Browser.Driver.FindElement(By.CssSelector(RubRubId));
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
