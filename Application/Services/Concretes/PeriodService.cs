using AcademicService.Application.Services.Abstracts;
using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Interfaces;

namespace AcademicService.Application.Services.Concretes
{
    public class PeriodService(
        IRepository<Period, int> repository
    ) : Service<Period, int>(repository)
    {
        
    }
}