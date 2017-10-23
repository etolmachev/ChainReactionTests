using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	public class SignInPage
	{
		public string EmailInputId = "input[name='/atg/userprofiling/ProfileFormHandler.value.login']";
		public string PasswordInputId = "#newpassword";
		public string SignInButtonId = "#loginFormSubmit";

		public IWebElement EmailInputElement;
		public IWebElement PassElement;
		public IWebElement SignInButtonElement;

		public SignInPage()
		{
			EmailInputElement = Browser.Driver.FindElement(By.CssSelector(EmailInputId));
			PassElement = Browser.Driver.FindElement(By.CssSelector(PasswordInputId));
			SignInButtonElement = Browser.Driver.FindElement(By.CssSelector(SignInButtonId));
		}

		public bool PageLoaded()
		{
			if (EmailInputElement.Displayed)
			{
				return true;
			}
			return false;
		}

		public void SignInClick()
		{
			SignInButtonElement.Click();
		}
	}
}
