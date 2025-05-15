using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace AcademicService.Infrastructure.Repositories.Concretes
{
    public class MiddleVacationRepository(DbContext context) : Repository<MiddleVacation, int>(context)
    {
        
    }
}