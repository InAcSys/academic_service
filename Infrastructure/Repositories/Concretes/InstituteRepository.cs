using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace AcademicService.Infrastructure.Repositories.Concretes
{
    public class InstituteRepository(DbContext context) : Repository<Institute, Guid>(context)
    {

    }
}