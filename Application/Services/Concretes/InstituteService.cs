using AcademicService.Application.Services.Abstracts;
using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Interfaces;

namespace AcademicService.Application.Services.Concretes
{
    public class InstituteService(
        IRepository<Institute, Guid> repository
    ) : Service<Institute, Guid>(repository)
    {

    }
}