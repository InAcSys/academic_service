using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AcademicService.Infrastructure.Repositories.Abstracts
{
    public abstract class AbstractInstituteRepository(
        DbContext context
    ) : Repository<Institute, Guid>(context), IInstituteRepository
    {
        public override Task<Institute?> Create(Institute entity)
        {
            entity.SubDomain = entity.SubDomain.ToLower();
            return base.Create(entity);
        }
        public async Task<bool> AssignPrincipal(Guid id, Guid principalId)
        {
            var institute = await GetById(id);
            if (institute is null)
            {
                throw new InvalidOperationException("Institute not found");
            }
            institute.Principal = principalId;
            var result = await Update(id, institute);
            return result is not null;
        }

        public async Task<bool> VerifySubDomainIsUnique(string subDomain)
        {
            subDomain = subDomain.ToLower();
            var result = await _context
                .Set<Institute>()
                .FirstOrDefaultAsync(x => x.SubDomain == subDomain);

            return result is not null;
        }
    }
}