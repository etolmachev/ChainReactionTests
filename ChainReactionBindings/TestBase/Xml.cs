using System.Xml;
using System.Xml.Linq;

namespace ChainReactionBindings.TestBase
{
	class Xml
	{
		public XElement document;
		public Xml()
		{
			 document = XElement.Load(@"D:\Git\ChainReactionTests\config.xml");
		}
		public string GetFolder()
		{
			var elem = document.Element("path").Value;
			return elem;
		}
		
	}
}
