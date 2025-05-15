using AcademicService.Application.Services.Abstracts;
using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Interfaces;

namespace AcademicService.Application.Services.Concretes
{
    public class DepartamentService(
        IRepository<Departament, int> repository
    ) : Service<Departament, int>(repository)
    {
        
    }
}