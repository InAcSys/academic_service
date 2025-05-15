using AcademicService.Application.Services.Abstracts;
using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Interfaces;

namespace AcademicService.Application.Services.Concretes
{
    public class CountryService(
        IRepository<Country, int> repository
    ) : Service<Country, int>(repository)
    {
        
    }
}