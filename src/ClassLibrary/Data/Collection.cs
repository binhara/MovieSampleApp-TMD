using System.Diagnostics;
using Newtonsoft.Json;

namespace ClassLibrary.Data
{
	[DebuggerDisplay("Id={Id}; Name={Name}")]
	public class Collection
	{
		public int Id { get; set; }
		public string Name { get; set; }
		[JsonProperty("backdrop_path")]
		public string BackdropPath { get; set; }
		[JsonProperty("poster_path")]
		public string PosterPath { get; set; }
	}
}

