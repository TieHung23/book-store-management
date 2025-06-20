using bsm.Application;
using bsm.Infrastructure;
using bsm.Presentation;
using Serilog;
namespace bsm.API
{
    public class Program
    {
        public static void Main( string[] args )
        {
            var builder = WebApplication.CreateBuilder( args );

            // Add services to the container.  

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle  
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddPresentation();
            builder.Services
                .AddApplication()
                .AddInfrastructure()
                .AddDbContext( builder.Configuration );

            builder.Host.UseSerilog( ( context, configuration ) =>
                configuration.ReadFrom.Configuration( context.Configuration ) );

            var app = builder.Build();

            // Configure the HTTP request pipeline.  
            if( app.Environment.IsDevelopment() )
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseSerilogRequestLogging();
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
