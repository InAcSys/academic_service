using AcademicService.Application.Services.Abstracts;
using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Interfaces;

namespace AcademicService.Application.Services.Concretes
{
    public class MiddleVacationService(
        IRepository<MiddleVacation, int> repository
    ) : Service<MiddleVacation, int>(repository)
    {
        
    }
}