using AcademicService.Application.Services.Abstracts;
using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Interfaces;

namespace AcademicService.Application.Services.Concretes
{
    public class CityService(
        IRepository<City, int> repository
    ) : Service<City, int>(repository)
    {
        
    }
}