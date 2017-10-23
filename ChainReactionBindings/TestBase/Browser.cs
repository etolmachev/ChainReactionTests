using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ChainReactionBindings.TestBase
{
	public static class Browser
	{
		public static bool IsInitialized = false;
		public static IWebDriver Driver;

		public static bool isInitialized()
		{
			return IsInitialized;
		}

		public static void BuildBrowser()
		{
			Driver = new ChromeDriver();
			Driver.Manage().Window.Maximize();
			IsInitialized = true;
		}

		public static void Quit()
		{
			Driver.Quit();
		}
	}
}