using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
	public class SignInPage : BasePage
	{
		private string EmailInputId = "input[name='/atg/userprofiling/ProfileFormHandler.value.login']";
		private string PasswordInputId = "#newpassword";
		private string SignInButtonId = "#loginFormSubmit";	    
		private string CreateAccountButtonId = "#confirmCreateAccount";
		private string CommonErrorId = "//form[@id='loginform']/p[position()=1]/label";
		private string ErrorEmailId = "//form[@id='loginform']/p[position()=3]/label";
		private string ErrorPasswordId = "//form[@id='loginform']/p[position()=4]/label";

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

		public bool SignInPageLoaded()
		{
			return PageLoaded(EmailInputElement);
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
