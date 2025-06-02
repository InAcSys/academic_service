using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace AcademicService.Infrastructure.Repositories.Concretes
{
    public class CityRepository(DbContext context) : AbstractChildRepository<City, int, int>(context)
    {
        
    }
}