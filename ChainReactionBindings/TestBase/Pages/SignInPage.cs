using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	public class SignInPage
	{
		public string EmailInputId = "input[name='/atg/userprofiling/ProfileFormHandler.value.login']";
		public string PasswordInputId = "#newpassword";
		public string SignInButtonId = "#loginFormSubmit";	    
		public string CreateAccountButtonId = "#confirmCreateAccount";
		public string CommonErrorId = "//form[@id='loginform']/p[position()=1]/label";
		public string ErrorEmailId = "//form[@id='loginform']/p[position()=3]/label";
		public string ErrorPasswordId = "//form[@id='loginform']/p[position()=4]/label";

		public HtmlElement EmailInputElement;
		public HtmlElement PasswordElement;
		public HtmlElement SignInButtonElement;
	    public HtmlElement CreateAccountButtonElement;
		public HtmlElement CommonErrorElement;
		public HtmlElement ErrorEmailElement;
		public HtmlElement ErrorPasswordElement;

		public SignInPage()
		{
			EmailInputElement = new HtmlElement(By.CssSelector(EmailInputId));
			PasswordElement = new HtmlElement(By.CssSelector(PasswordInputId));
			SignInButtonElement = new HtmlElement(By.CssSelector(SignInButtonId));
			CreateAccountButtonElement = new HtmlElement(By.CssSelector(CreateAccountButtonId));
			CommonErrorElement = new HtmlElement(By.XPath(CommonErrorId));
			ErrorEmailElement = new HtmlElement(By.XPath(ErrorEmailId));
			ErrorPasswordElement = new HtmlElement(By.XPath(ErrorPasswordId));
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
