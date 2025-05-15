using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace AcademicService.Infrastructure.Repositories.Concretes
{
    public class TypeRepository(DbContext context) : Repository<InstituteType, int>(context)
    {
        
    }
}