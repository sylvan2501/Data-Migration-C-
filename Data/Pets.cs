using System;
namespace DBContextExample.Data
{
	public class Pets
	{
		public int id { get; set; }
		public string Name { get; set; }
		public string Owner { get; set; }
		public string Species { get; set; }
		public string Sex { get; set; }
		public DateTime? Birth { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public Pets()
		{
		}
	}
}

