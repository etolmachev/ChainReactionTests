using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public IWebElement FirstNameElement;
        public IWebElement LastNameElement;
        public IWebElement EmailElement;
        public IWebElement ConfirmEmailElement;
        public IWebElement PasswordElement;
        public IWebElement ConfirmPasswordElement;
        public IWebElement ApplyButtonElement;
        public CreateAccountPage()
        {
            FirstNameElement = Browser.Driver.FindElement(By.CssSelector(FirstNameId));
            LastNameElement = Browser.Driver.FindElement(By.CssSelector(LastNameId));
            EmailElement = Browser.Driver.FindElement(By.CssSelector(EmailId));
            ConfirmEmailElement = Browser.Driver.FindElement(By.CssSelector(ConfirmEmailId));
            PasswordElement = Browser.Driver.FindElement(By.CssSelector(PasswordId));
            ConfirmPasswordElement = Browser.Driver.FindElement(By.CssSelector(ConfirmPasswordId));
            ApplyButtonElement = Browser.Driver.FindElement(By.CssSelector(ApplyButtonId));
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
