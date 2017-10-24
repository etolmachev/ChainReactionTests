using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	public class SignInPage
	{
		public string EmailInputId = "input[name='/atg/userprofiling/ProfileFormHandler.value.login']";
		public string PasswordInputId = "#newpassword";
		public string SignInButtonId = "#loginFormSubmit";

		public HtmlElement EmailInputElement;
		public HtmlElement PassElement;
		public HtmlElement SignInButtonElement;

		public SignInPage()
		{
			EmailInputElement = new HtmlElement(By.CssSelector(EmailInputId));
			PassElement = new HtmlElement(By.CssSelector(PasswordInputId));
			SignInButtonElement = new HtmlElement(By.CssSelector(SignInButtonId));
		}

		public bool PageLoaded()
		{
			Browser.WaitReadyState();
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
