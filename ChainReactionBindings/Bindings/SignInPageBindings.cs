using System;
using ChainReactionBindings.TestBase.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
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
			page.EmailInputElement.Clear();
			page.PasswordElement.Clear();
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
						page.PasswordElement.SendKeys(fieldValue);
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

		[Then(@"I see the The Email Address Or Password You Entered Is Incorrect message on Sing In page")]
		public void ThenISeeTheEmailAddressOrPasswordYouEnteredIsIncorrect()
		{
			Assert.AreEqual("Неправильный Email Или Пароль", page.CommonErrorElement.Text);
		}

		[Then(@"I see Please Enter Your Email Address To Continue message on Sign In page")]
		public void ThenISeePleaseEnterYourEmailAddressToContinueMessageOnSignInPage()
		{
			Assert.AreEqual("Пожалуйста, Укажите Ваш Адрес Электронной Почты", page.ErrorEmailElement.Text);
			page.EmailInputElement.Clear();
		}

		[Then(@"I see Please Enter Your Password To Continue message on Sign In page")]
		public void ThenISeePleaseEnterYourPasswordToContinueMessageOnSignInPage()
		{
			Assert.AreEqual("Чтобы Продолжить, Пожалуйста, Введите Ваш Пароль", page.ErrorPasswordElement.Text);
		}

		[When(@"I click on Create Account button")]
	    public void WhenIClickCreateAccountButton()
	    {
            page.CreateAccountClick();
	    }

	}
}
