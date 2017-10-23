using System;
using ChainReactionBindings.TestBase.Pages;
using TechTalk.SpecFlow;

namespace ChainReactionBindings.Bindings
{
	[Binding]
	public class SignInPageBindings
	{
		public SignInPage page = new SignInPage();

		[Then(@"I see the Sign In page is loaded")]
		public void ThenISeeTheSignInPageIsLoaded()
		{
			if (!page.PageLoaded())
			{
				throw new Exception("Sign in page is not loaded!");
			}
		}

		[When(@"I set following parameters on Sign In page")]
		public void WhenISetFollowingParametersOnSignInPage(Table table)
		{
			foreach (var row in table.Rows)
			{
				var fieldName = row["Name"];
				var fieldValue = row["Value"];

				switch (fieldName)
				{
					case "email":
						page.EmailInputElement.SendKeys(fieldValue);
						break;
					case "password":
						page.PassElement.SendKeys(fieldValue);
						break;
					default:
						throw new Exception(string.Format("Field {0} is not implemented", fieldName));
				}
			}
		}

		[When(@"I click Sign In button")]
		public void WhenIClickSignInButton()
		{
			page.SignInClick();
		}

	}
}
