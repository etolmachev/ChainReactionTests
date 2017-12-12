using System.Xml;
using System.Xml.Linq;

namespace ChainReactionBindings.TestBase
{
	class Config
	{
		public XElement document;
		public Config()
		{
			 document = XElement.Load(@"C:\Users\ekustova\config.xml");
		}
		public string ScreenshotFolder()
		{
			var elem = document.Element("path").Value;
			return elem;
		}
		
	}
}
