﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

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
		public string WishlistButtonId = ".crcHeaderWishlist";
		public string BasketId = "div.cart_container a";
		public string CloseBasketId = ".minicart_close";
		public string BasketMessageId = ".basket-head-title";
		public string LogoId = ".crc_logo";
		public string HeaderId = ".header";

		public HtmlElement ShopByCategoryElement;
		public HtmlElement BrandsElement;
		public HtmlElement SignInElement;
		public HtmlElement RubRubElement;
		public HtmlElement SelectLanguageElement;
		public SelectElement EnglishLanguagElement;
		public HtmlElement UpdateButtonElement;
		public HtmlElement WishlistButtonElement;
		public HtmlElement BasketElement;
		public HtmlElement CloseBasketElement;
		public HtmlElement BasketMessageElement;
		public HtmlElement LogoElement;
		public HtmlElement HeaderElement;

		public TopMenu()
		{
			ShopByCategoryElement = new HtmlElement(By.CssSelector(ShopByCategoryId));
			BrandsElement = new HtmlElement(By.CssSelector(BrandsId));
			SignInElement = new HtmlElement(By.CssSelector(SignInId));
			RubRubElement = new HtmlElement(By.CssSelector(RubRubId));
			WishlistButtonElement = new HtmlElement(By.CssSelector(WishlistButtonId));
			BasketElement = new HtmlElement(By.CssSelector(BasketId));
			CloseBasketElement = new HtmlElement(By.CssSelector(CloseBasketId));
			BasketMessageElement = new HtmlElement(By.CssSelector(BasketMessageId));
			LogoElement = new HtmlElement(By.CssSelector(LogoId));
			HeaderElement = new HtmlElement(By.CssSelector(HeaderId));
		}

		public void ClickSignIn()
		{
			SignInElement.Click();
		}

		public void OpenRub()
		{
			RubRubElement.Click();
		}

		public void Update()
		{
			UpdateButtonElement.Click();
		}

		public void OpenWishlist()
		{
			WishlistButtonElement.Click();
		}

		public void OpenBasket()
		{
			BasketElement.Click();
		}

		public void LogoClick()
		{
			LogoElement.Click();
		}
		public void ScrollToBasket()
		{
			var element = HeaderElement.FindElement(By.CssSelector(RubRubId));
			Actions act = new Actions(Browser.Driver);
			act.MoveToElement(element);
			act.Perform();
		}
	}
}
