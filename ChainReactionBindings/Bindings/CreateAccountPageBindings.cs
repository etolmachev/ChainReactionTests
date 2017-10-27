using System;
using ChainReactionBindings.TestBase.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            if (!page.CreateAccountPageLoaded())
            {
                throw new Exception("Sign in page is not loaded!");
            }
        }

        [When(@"I set following parameters on Create Account page")]
        public void WhenISetFollowingParametersOnCreateAccountPage(Table table)
        {
	        string randNumber = Random(3);
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
				        page.EmailElement.SendKeys(fieldValue + "+" + randNumber + "@gmail.com");
				        break;
				    case "confirmEmail":
				        page.ConfirmEmailElement.SendKeys(fieldValue + "+" + randNumber + "@gmail.com");
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

	    [Then(@"I see ""(.*)"" message on Create Account page")]
	    public void SeeMessageOnCreateAccountPage(string textMessage)
	    {
		    switch (textMessage)
		    {
				case "Please Enter Your First Name":
					Assert.AreEqual(textMessage, page.FirstNameErrorElement.Text);
					break;
				case "Please Enter Your Last Name":
					Assert.AreEqual(textMessage, page.LastNameErrorElement.Text);
					break;
			    case "Please Enter Your Email Address":
				    Assert.AreEqual(textMessage, page.EmailErrorElement.Text);
					break;
			    case "Please Enter Password":
				    Assert.AreEqual(textMessage, page.PasswordErrorElement.Text);
					break;
			    case "Please Enter At Least 8 Characters":
				    Assert.AreEqual(textMessage, page.PasswordErrorElement.Text);
				    break;
				case "Confirm Password And New Password Does Not Match":
				    Assert.AreEqual(textMessage, page.ConfirmPasswordErrorElement.Text);
					break;
			    case "Email Address And Confirm Email Address Does Not Match":
				    Assert.AreEqual(textMessage, page.ConfirmEmailErrorElement.Text);
				    break;
				default: throw new Exception(string.Format("Message {0} is not implemented", textMessage));
			}
			
	    }

	    public string Random(int count)
	    {
		    string numberForEmail = "";
		    for (int i = 0; i < count; i++)
		    {
			    Random r = new Random();
			    int s = r.Next(1, 4);
				numberForEmail += s.ToString();
		    }
		    return numberForEmail;
	    }

	}
}
