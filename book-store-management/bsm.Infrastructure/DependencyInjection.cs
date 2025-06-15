using bsm.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace bsm.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure( this IServiceCollection services )
        {
            return services;
        }

        public static IServiceCollection AddDbContext( this IServiceCollection services, IConfiguration configuration )
        {
            services.AddDbContext<DataContext>( options =>
                    options.UseSqlServer( configuration.GetConnectionString( "DefaultConnection" ) ) );
            return services;
        }
    }
}
