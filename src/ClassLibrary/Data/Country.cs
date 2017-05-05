using System.Diagnostics;
using Newtonsoft.Json;

namespace ClassLibrary.Data
{
	[DebuggerDisplay("CountryCode={CountryCode}; Name={Name}")]
	public class Country
	{
		[JsonProperty("iso_3166_1")]
		public string CountryCode { get; set; }
		public string Name { get; set; }
	}
}

