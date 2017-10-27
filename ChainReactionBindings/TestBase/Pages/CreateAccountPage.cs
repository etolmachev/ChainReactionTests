using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
    public class CreateAccountPage
    {
        public string FirstNameId = "input[name='/atg/userprofiling/ProfileFormHandler.value.firstName']";
        public string LastNameId = "input[name='/atg/userprofiling/ProfileFormHandler.value.lastName']";
        public string EmailId = "input[name='/atg/userprofiling/ProfileFormHandler.value.email']";
        public string ConfirmEmailId = "input[name='/atg/userprofiling/ProfileFormHandler.value.confirmEmail']";
        public string PasswordId = "#newpassword";
        public string ConfirmPasswordId = "input[name='/atg/userprofiling/ProfileFormHandler.value.confirmPassword']";
        public string ApplyButtonId = "input.blue_btn";
	    public string FirstNameErrorId = "label[for= 'firstname']";
	    public string LastNameErrorId = "label[for='lastName']";
	    public string EmailErrorId = "label[for='email']";
	    public string ConfirmEmaileErrorId = "label[for='confirmEmail']";
	    public string PasswordErrorId = "label[for='password']";
	    public string ConfirmPasswordErrorId = "label[for='confirmPassword']";

		public HtmlElement FirstNameElement;
        public HtmlElement LastNameElement;
        public HtmlElement EmailElement;
        public HtmlElement ConfirmEmailElement;
        public HtmlElement PasswordElement;
        public HtmlElement ConfirmPasswordElement;
        public HtmlElement ApplyButtonElement;
	    public HtmlElement FirstNameErrorElement;
	    public HtmlElement LastNameErrorElement;
	    public HtmlElement EmailErrorElement;
	    public HtmlElement ConfirmEmailErrorElement;
	    public HtmlElement PasswordErrorElement;
	    public HtmlElement ConfirmPasswordErrorElement;
        public CreateAccountPage()
        {
            FirstNameElement = new HtmlElement(By.CssSelector(FirstNameId));
            LastNameElement = new HtmlElement(By.CssSelector(LastNameId));
            EmailElement = new HtmlElement(By.CssSelector(EmailId));
            ConfirmEmailElement = new HtmlElement(By.CssSelector(ConfirmEmailId));
            PasswordElement = new HtmlElement(By.CssSelector(PasswordId));
            ConfirmPasswordElement = new HtmlElement(By.CssSelector(ConfirmPasswordId));
            ApplyButtonElement = new HtmlElement(By.CssSelector(ApplyButtonId));
			FirstNameErrorElement = new HtmlElement(By.CssSelector(FirstNameErrorId));
			LastNameErrorElement = new HtmlElement(By.CssSelector(LastNameErrorId));
			EmailErrorElement = new HtmlElement(By.CssSelector(EmailErrorId));
			ConfirmEmailErrorElement = new HtmlElement(By.CssSelector(ConfirmEmaileErrorId));
			PasswordErrorElement = new HtmlElement(By.CssSelector(PasswordErrorId));
			ConfirmPasswordErrorElement = new HtmlElement(By.CssSelector(ConfirmPasswordErrorId));
        }

        public bool PageLoaded()
        {
            if (FirstNameElement.Displayed)
            {
                return true;
            }
            return false;
        }

        public void ApplyClick()
        {
            ApplyButtonElement.Click();
        }
    
    }
}
