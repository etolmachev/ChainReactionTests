using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
    public class MyAccountPage : BasePage
    {
        private string PersonalInfoId = "span.content_head";

        public HtmlElement PersonalInfoElement;

        public MyAccountPage()
        {
            PersonalInfoElement = new HtmlElement(By.CssSelector(PersonalInfoId));
        }
        public bool MyAccountPageLoaded()
        {
	        return PageLoaded(PersonalInfoElement);
        }
    }
}
