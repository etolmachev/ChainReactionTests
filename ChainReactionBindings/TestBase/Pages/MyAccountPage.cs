using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
    public class MyAccountPage
    {
        public string PersonalInfoId = "span.content_head";

        public HtmlElement PersonalInfoElement;

        public MyAccountPage()
        {
            PersonalInfoElement = new HtmlElement(By.CssSelector(PersonalInfoId));
        }
        public bool PageLoaded()
        {
            if (PersonalInfoElement.Displayed)
            {
                return true;
            }
            return false;
        }
    }
}
