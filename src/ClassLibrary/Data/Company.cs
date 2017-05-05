using System.Diagnostics;

namespace ClassLibrary.Data
{
	[DebuggerDisplay("Id={Id}; Name={Name}")]
	public class Company
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}

