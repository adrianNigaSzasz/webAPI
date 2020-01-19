using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Data.Entities
{
	public class Rate
	{
		public int Id { get; set; }

		public string Code { get; set; }
		public Price Price { get; set; }
	}
}
