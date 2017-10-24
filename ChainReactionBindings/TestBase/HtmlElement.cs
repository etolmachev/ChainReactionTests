﻿using System;
using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ChainReactionBindings.TestBase
{
	public class HtmlElement: IWebElement
	{
		private readonly How _locatorHow;
		private readonly string _locatorString;

		private By _elementLocator;
		private IWebElement _wrappedElement;
		private string Name { get; set; }

		public IWebElement WrappedElement
		{
			get { return GetWebElement(); }
			private set { _wrappedElement = value; }
		}

		public HtmlElement(By thisElementLocator)
		{
			_elementLocator = thisElementLocator;
		}

		private IWebElement GetWebElement()
		{
			if (_elementLocator != null && _wrappedElement == null)
			{
				GetThisElement();
			}

			try
			{
				// Get element property to define if is still valid
				var t = _wrappedElement.Enabled;
			}
			catch (StaleElementReferenceException)
			{
				GetThisElement();
			}

			return _wrappedElement;
		}

		private void GetThisElement()
		{
			IWebElement element;

			if (null == _elementLocator)
			{
				throw new ArgumentException(string.Format("Unable to locate element. Locator is not provided."));
			}

			try
			{
				element = Browser.Driver.FindElement(_elementLocator);
			}
			catch (NoSuchElementException)
			{
				element = null;
			}

			if (element == null)
			{
				throw new NoSuchElementException(string.Format("Locator {0} does not match any element",
					string.Join(", ", _elementLocator)));
			}
			WrappedElement = element;
		}

		//Implement Interface properties and methods
		#region
		public void Click()
		{
			WrappedElement.Click();
		}

		public void Submit()
		{
			WrappedElement.Submit();
		}

		public void SendKeys(string keys)
		{
			WrappedElement.SendKeys(keys);
		}

		public void Clear()
		{
			WrappedElement.Clear();
		}

		public string GetCssValue(string name)
		{
			return WrappedElement.GetCssValue(name);
		}

		public string GetAttribute(string name)
		{
			return WrappedElement.GetAttribute(name);
		}

		public string TagName
		{
			get { return WrappedElement.TagName; }
		}

		public string Text
		{
			get { return WrappedElement.Text; }
		}

		public bool Enabled
		{
			get { return WrappedElement.Enabled; }
		}

		public bool Selected
		{
			get { return WrappedElement.Selected; }
		}

		public Point Location
		{
			get { return WrappedElement.Location; }
		}

		public Size Size
		{
			get { return WrappedElement.Size; }
		}

		public bool Displayed
		{
			get { return WrappedElement.Displayed; }
		}

		public IWebElement FindElement(By by)
		{
			return WrappedElement.FindElement(by);
		}

		public ReadOnlyCollection<IWebElement> FindElements(By by)
		{
			return WrappedElement.FindElements(by);
		}

		public string GetProperty(string propertyName)
		{
			return WrappedElement.GetProperty(propertyName);
		}
		#endregion
	}
}
