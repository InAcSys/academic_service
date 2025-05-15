using AcademicService.Application.Services.Abstracts;
using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Interfaces;

namespace AcademicService.Application.Services.Concretes
{
    public class TypeService(
        IRepository<InstituteType, int> repository
    ) : Service<InstituteType, int>(repository)
    {
        
    }
}