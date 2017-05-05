using System.Collections.Generic;
using Newtonsoft.Json;

namespace ClassLibrary.Data
{
	public class Configuration
	{
		public Images Images { get; set; }

		[JsonProperty("change_keys")]
		public List<string> ChangeKeys { get; set; }
	}
}

