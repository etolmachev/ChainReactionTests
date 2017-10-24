using OpenQA.Selenium;

namespace ChainReactionBindings.TestBase.Pages
{
    public class MyAccountPage
    {
        public string PersonalInfoId = "span.content_head";

        public IWebElement PersonalInfoElement;

        public MyAccountPage()
        {
            PersonalInfoElement = Browser.Driver.FindElement(By.CssSelector(PersonalInfoId));
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
