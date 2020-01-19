using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;

namespace Hotel.Data
{
	class ApiDbContextFactory : IDesignTimeDbContextFactory<ApiDbContext>
	{
        public ApiDbContext CreateDbContext(string[] args)
        {
            // todo, this should be as configuration
            //var connectionString = ConfigurationManager.ConnectionStrings["APIDatabase"].ConnectionString;
               

            var builder = new DbContextOptionsBuilder<ApiDbContext>();

            builder.UseSqlServer("Server=.;Initial Catalog=API;;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new ApiDbContext(builder.Options);
        }
    }
}
