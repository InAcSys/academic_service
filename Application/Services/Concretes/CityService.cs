using AcademicService.Application.Services.Abstracts;
using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Interfaces;

namespace AcademicService.Application.Services.Concretes
{
    public class CityService(
        IChildRepository<City, int, int> repository
    ) : AbstractChildService<City, int, int>(repository)
    {
        
    }
}