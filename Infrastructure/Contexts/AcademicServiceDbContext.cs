using Microsoft.EntityFrameworkCore;

namespace AcademicService.Infrastructure.Contexts
{
    public class AcademicServiceDbContext(DbContextOptions options) : DbContext(options)
    {
        
    }
}