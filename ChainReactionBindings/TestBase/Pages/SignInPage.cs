using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	public class SignInPage
	{
		public string EmailInputId = "input[name='/atg/userprofiling/ProfileFormHandler.value.login']";
		public string PasswordInputId = "#newpassword";
		public string SignInButtonId = "#loginFormSubmit";	    
		public string CreateAccountButtonId = "#confirmCreateAccount";

		public HtmlElement EmailInputElement;
		public HtmlElement PassElement;
		public HtmlElement SignInButtonElement;
	    public IWebElement CreateAccountButtonElement;

		public SignInPage()
		{
			EmailInputElement = new HtmlElement(By.CssSelector(EmailInputId));
			PassElement = new HtmlElement(By.CssSelector(PasswordInputId));
			SignInButtonElement = new HtmlElement(By.CssSelector(SignInButtonId));
		    CreateAccountButtonElement = Browser.Driver.FindElement(By.CssSelector(CreateAccountButtonId));
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

	    public void CreateAccountClick()
	    {
            CreateAccountButtonElement.Click();
	    }
	}
}
