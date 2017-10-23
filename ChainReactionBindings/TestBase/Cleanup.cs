using TechTalk.SpecFlow;

namespace ChainReactionBindings.TestBase
{
	[Binding]
	public class Cleanup
	{
		[AfterScenario]
		public void closeBrowser()
		{
			Browser.Quit();
		}
	}
}
