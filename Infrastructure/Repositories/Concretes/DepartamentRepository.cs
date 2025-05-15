using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace AcademicService.Infrastructure.Repositories.Concretes
{
    public class DepartamentRepository(DbContext context) : Repository<Departament, int>(context)
    {
        
    }
}