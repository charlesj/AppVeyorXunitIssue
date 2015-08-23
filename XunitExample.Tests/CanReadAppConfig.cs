using System.Configuration;
using Xunit;

namespace XunitExample.Tests
{
    public class CanReadAppConfig
    {
	    [Fact]
	    public void ReadTheConfig()
	    {
		    var canRead = ConfigurationManager.AppSettings["CanRead"];
		    Assert.True(!string.IsNullOrEmpty(canRead));
	    }
    }
}