using AcademicService.Application.Services.Abstracts;
using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Interfaces;

namespace AcademicService.Application.Services.Concretes
{
    public class NatureService(
        IRepository<Nature, int> repository
    ) : Service<Nature, int>(repository)
    {
        
    }
}