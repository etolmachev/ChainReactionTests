using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ChainReactionBindings.TestBase.Pages
{
	public class TopMenu : BasePage
	{
		public string ShopByCategoryId = "li.shop_category";
		public string BrandsId = "li.searchmenu";
		public string SignInId = "li.signin_createact";
		public string RubRubId = "li.crcHeaderCountryCurrency";
		public string SelectLanguageId = "select[name='/atg/userprofiling/ProfileFormHandler.value.language']";
		public string UpdateButtonId = "input[name='/atg/userprofiling/ProfileFormHandler.updateLocaleInfo']";

		public HtmlElement ShopByCategoryElement;
		public HtmlElement BrandsElement;
		public HtmlElement SignInElement;
		public HtmlElement RubRubElement;
		public HtmlElement SelectLanguageElement;
		public SelectElement EnglishLanguagElement;
		public HtmlElement UpdateButtonElement;

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

		public void SelectLanguage()
		{
			SelectLanguageElement.Click();
		}

		public void Update()
		{
			UpdateButtonElement.Click();
		}
	}
}
