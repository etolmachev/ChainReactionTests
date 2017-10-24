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

        public HtmlElement FirstNameElement;
        public HtmlElement LastNameElement;
        public HtmlElement EmailElement;
        public HtmlElement ConfirmEmailElement;
        public HtmlElement PasswordElement;
        public HtmlElement ConfirmPasswordElement;
        public HtmlElement ApplyButtonElement;
        public CreateAccountPage()
        {
            FirstNameElement = new HtmlElement(By.CssSelector(FirstNameId));
            LastNameElement = new HtmlElement(By.CssSelector(LastNameId));
            EmailElement = new HtmlElement(By.CssSelector(EmailId));
            ConfirmEmailElement = new HtmlElement(By.CssSelector(ConfirmEmailId));
            PasswordElement = new HtmlElement(By.CssSelector(PasswordId));
            ConfirmPasswordElement = new HtmlElement(By.CssSelector(ConfirmPasswordId));
            ApplyButtonElement = new HtmlElement(By.CssSelector(ApplyButtonId));
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
