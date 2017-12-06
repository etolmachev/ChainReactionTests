using ChainReactionBindings.TestBase.Pages;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace ChainReactionBindings.TestBase
{
	class BasketPage : BasePage
	{
		private string TotalCostId = ".chk_tot2";
		private string MessageId = ".from1";
		private string ItemsContainerId = ".cartitem_bgcontent";
		private string SubtotalId = ".chk_tot";
		private string ContinueShoppingId = ".continueshoppingtext";
		private string FindItemId = "//div[contains(@class,'cartitem_container') and ./div/div/ul/li/h4/a[contains(text(),'{0}')]]";
		private string RemoveItemButtonId = ".//form[contains(@name,'remItemForm')]/a";

		public HtmlElement TotalCostElement;
		public HtmlElement MessageElement;
		public HtmlElement ItemsContainerElement;
		public HtmlElement SubtotalElement;
		public HtmlElement ContinueShoppingElement;


		public BasketPage()
		{
			TotalCostElement = new HtmlElement(By.CssSelector(TotalCostId));
			MessageElement = new HtmlElement(By.CssSelector(MessageId));
			ItemsContainerElement = new HtmlElement(By.CssSelector(ItemsContainerId));
			SubtotalElement = new HtmlElement(By.CssSelector(SubtotalId));
			ContinueShoppingElement = new HtmlElement(By.CssSelector(ContinueShoppingId));
		}

		public bool BasketPageLoaded()
		{
			return PageLoaded(TotalCostElement);
		}

		public int GetItems()
		{
			return ItemsContainerElement.FindElements(By.ClassName("cartitem_container")).Count;
		}

		public void ContinueShopping()
		{
			ContinueShoppingElement.Click();
		}

		public HtmlElement GetItem(string name)
		{
			return new HtmlElement(By.XPath(string.Format(FindItemId, name)));
		}
		public string GetItemName(HtmlElement el)
		{
			return el.FindElement(By.CssSelector("h4 a")).Text;
		}

		public string GetItemQuantity(HtmlElement el)
		{
			return el.FindElement(By.XPath(".//li[@class='cart_display']/input[contains(@id, 'quant')]")).GetAttribute("value");
		}
		public string GetItemPrice(HtmlElement el)
		{
			return el.FindElement(By.ClassName("fromamt")).Text;
		}

		public string GetItemOption(HtmlElement el)
		{
			return el.FindElement(By.XPath(".//div[@class='cartitem_col1']/ul/li[position()=2]")).Text;
		}
		public void RemoveItem(string name)
		{
			var el = new HtmlElement(By.XPath(string.Format(FindItemId, name)));
			el.FindElement(By.XPath(RemoveItemButtonId)).Click();
			Thread.Sleep(TimeSpan.FromSeconds(1));
		}
		public void RemoveItemBackground(string index)
		{
			string Id = "form[name='remItemForm" + index + "'] a";
			ItemsContainerElement.FindElement(By.CssSelector(Id)).Click();
		}
	}
}
