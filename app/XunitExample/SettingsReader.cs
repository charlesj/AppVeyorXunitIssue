using System.Configuration;

namespace XunitExample
{
    public class SettingsReader
    {
	    public SettingsReader()
	    {
		    this.CanRead = ConfigurationManager.AppSettings["CanRead"];
	    }

	    public string CanRead { get; set; }
    }
}
