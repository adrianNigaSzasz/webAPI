using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Hotel.Data.Entities;
using System.Configuration;

namespace Hotel.Data
{
	public class ApiDbContext : DbContext
	{

		public ApiDbContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=.;Initial Catalog=API;;Trusted_Connection=True;MultipleActiveResultSets=true");
		}



		public DbSet<Hotel.Data.Entities.Hotel> Hotels { get; set; }

		public DbSet<Room> Rooms { get; set; }

		public DbSet<City> Cities { get; set; }

		public DbSet<Country> Countries { get; set; }

		public DbSet<Currency> Currencies { get; set; }
	}
}
