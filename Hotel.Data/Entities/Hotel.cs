using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Data.Entities
{
	public class Hotel
	{
		public int Id { get; set; } 
		public string Name { get; set; }

		public City City { get; set; }

		public Country Country { get; set; }

		public List<Room> Rooms = new List<Room>();

	}
}
