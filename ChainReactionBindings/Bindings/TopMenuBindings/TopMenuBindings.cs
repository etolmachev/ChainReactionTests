using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainReactionBindings.TestBase;
using ChainReactionBindings.TestBase.Pages;
using TechTalk.SpecFlow;

namespace ChainReactionBindings.Bindings.TopMenuBindings
{
	[Binding]
	public class TopMenuBindings
	{
		public TopMenu page = new TopMenu();

		[When(@"I click on Sign In on top menu")]
		public void WhenIClickOnSignInOnTopMenu()
		{
			page.ClickSignIn();
		}

	}
}
