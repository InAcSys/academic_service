using System.Reflection;
using AcademicService.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AcademicService.Presentation.Configurations
{
    public static class Configuration
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services)
        {
            var connection = Environment.GetEnvironmentVariable("ACADEMIC_SERVICE_DATABASE_STRING_CONNECTION");

            if (string.IsNullOrEmpty(connection))
            {
                throw new ArgumentException("Connection not found");
            }

            services.AddDbContext<DbContext, AcademicServiceDbContext>(
                options => options.UseNpgsql(
                    connection,
                    b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name)
                )
            );

            return services;
        }
    }
}