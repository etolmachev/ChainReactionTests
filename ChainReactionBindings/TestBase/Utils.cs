using OpenQA.Selenium;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using TechTalk.SpecFlow;

namespace ChainReactionBindings.TestBase
{
	public static class Utils
	{
		private readonly static string patternFunction = "::(.*)}}";
		private readonly static string patternValue = "{{(.*)::";
		private readonly static string patternReplace = "({{(.*)}})";

		public static string ResolveExpression(string expression)
		{
			string result;
			string matchFunction = Regex.Match(expression, patternFunction).Groups[1].ToString();
			string matchValue = Regex.Match(expression, patternValue).Groups[1].ToString();
			switch (matchFunction)
			{
				case "rnd":
					result = Regex.Replace(expression, patternReplace, Random(int.Parse(matchValue)));
					break;
				case "context":
					result = Regex.Replace(expression, patternReplace, GetFromContext(matchValue));
					break;
				case "":
					return expression;
				default:
					throw new Exception(string.Format("Can't resolve {0}", expression));
			}
			return result;
		}

		public static string Random(int count)
		{
			string numberForEmail = "";
			for (int i = 0; i < count; i++)
			{
				Random r = new Random();
				Thread.Sleep(TimeSpan.FromMilliseconds(500));
				int s = r.Next(0, 9);
				numberForEmail += s.ToString();
			}
			return numberForEmail;
		}

		public static string GetFromContext(string key)
		{
			return ScenarioContext.Current.Get<string>(key);
		}

		public static void TakeScreenshot(string scenario, string feature)
		{
			try
			{
				Screenshot ss = ((ITakesScreenshot)Browser.Driver).GetScreenshot();
				Config config = new Config();
				string folder = config.ScreenshotFolder();
				ss.SaveAsFile(folder + feature + "_" + scenario + ".jpg",ScreenshotImageFormat.Jpeg);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				throw;
			}
		}
	}
}
