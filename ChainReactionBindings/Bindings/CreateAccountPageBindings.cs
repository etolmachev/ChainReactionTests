using System;
using ChainReactionBindings.TestBase.Pages;
using TechTalk.SpecFlow;

namespace ChainReactionBindings.Bindings
{
    [Binding]
    class CreateAccountPageBindings
    {
        public CreateAccountPage page = new CreateAccountPage();

        [Then(@"I see the Create Account page is loaded")]
        public void ThenISeeTheCreateAccountPageIsLoaded()
        {
            if (!page.PageLoaded())
            {
                throw new Exception("Sign in page is not loaded!");
            }
        }

        [When(@"I set following parameters on Create Account page")]
        public void WhenISetFollowingParametersOnCreateAccountPage(Table table)
        {
            foreach (var row in table.Rows)
			{
				var fieldName = row["Name"];
				var fieldValue = row["Value"];

				switch (fieldName)
				{
					case "first":
						page.FirstNameElement.SendKeys(fieldValue);
						break;
					case "last":
						page.LastNameElement.SendKeys(fieldValue);
						break;
				    case "email":
				        page.EmailElement.SendKeys(fieldValue);
				        break;
				    case "confirmEmail":
				        page.ConfirmEmailElement.SendKeys(fieldValue);
				        break;
				    case "password":
				        page.PasswordElement.SendKeys(fieldValue);
				        break;
				    case "confirmPassword":
				        page.ConfirmPasswordElement.SendKeys(fieldValue);
				        break;
                    default:
						throw new Exception(string.Format("Field {0} is not implemented", fieldName));
				}
			}
        }

        [When(@"I click Apply button")]
        public void WhenIClickApplyButton()
        {
            page.ApplyClick();
        }

    }
}
