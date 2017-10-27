using System;
using ChainReactionBindings.TestBase.Pages;
using TechTalk.SpecFlow;

namespace ChainReactionBindings.Bindings
{
    [Binding]
    class MyAccountPageBindings
    {
        MyAccountPage page = new MyAccountPage();

        [Then(@"I see My Account page is loaded")]
        public void ThenISeeMyAccountPageIsLoaded()
        {
            if (!page.MyAccountPageLoaded())
            {
                throw new Exception("Sign in page is not loaded!");
            }
        }
    }
}
