using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace bsm.Infrastructure.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext( string[] args )
        {
            var config = new ConfigurationBuilder()
                .SetBasePath( Path.Combine( Directory.GetCurrentDirectory(), "../bsm.API" ) )
                .AddJsonFile( "appsettings.json" )
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer( config.GetConnectionString( "DefaultConnection" ) );

            return new DataContext( optionsBuilder.Options );
        }
    }

}
