using AcademicService.Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace AcademicService.Infrastructure.Contexts
{
    public class AcademicServiceDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Institute> Institutes { get; set; }
        public DbSet<InstituteType> Types { get; set; }
        public DbSet<Nature> Natures { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<MiddleVacation> MiddleVacations { get; set; }
    }
}