using Xunit;

namespace XunitExample.Tests
{
	public class CanReadUsingMiddleClass
	{
		[Fact]
		public void UseSettingsToReadAppConfig()
		{
			var settingsReader = new SettingsReader();
			Assert.True(!string.IsNullOrEmpty(settingsReader.CanRead));
		}
	}
}