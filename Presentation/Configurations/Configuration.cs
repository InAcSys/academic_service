using System.Reflection;
using AcademicService.Application.Services.Concretes;
using AcademicService.Application.Services.Interfaces;
using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Contexts;
using AcademicService.Infrastructure.Repositories.Concretes;
using AcademicService.Infrastructure.Repositories.Interfaces;
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

            services.AddScoped<IService<Institute, Guid>, InstituteService>();
            services.AddScoped<IService<InstituteType, int>, TypeService>();
            services.AddScoped<IService<Nature, int>, NatureService>();
            services.AddScoped<IService<Period, int>, PeriodService>();
            services.AddScoped<IService<MiddleVacation, int>, MiddleVacationService>();
            services.AddScoped<IService<Country, int>, CountryService>();
            services.AddScoped<IService<Departament, int>, DepartamentService>();
            services.AddScoped<IService<City, int>, CityService>();

            services.AddScoped<IRepository<Institute, Guid>, InstituteRepository>();
            services.AddScoped<IRepository<InstituteType, int>, TypeRepository>();
            services.AddScoped<IRepository<Nature, int>, NatureRepository>();
            services.AddScoped<IRepository<Period, int>, PeriodRepository>();
            services.AddScoped<IRepository<MiddleVacation, int>, MiddleVacationRepository>();
            services.AddScoped<IRepository<Country, int>, CountryRepository>();
            services.AddScoped<IRepository<Departament, int>, DepartamentRepository>();
            services.AddScoped<IRepository<City, int>, CityRepository>();

            return services;
        }
    }
}