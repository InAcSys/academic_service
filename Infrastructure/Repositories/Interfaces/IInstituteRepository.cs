using AcademicService.Domain.Entities.Concretes;

namespace AcademicService.Infrastructure.Repositories.Interfaces
{
    public interface IInstituteRepository : IRepository<Institute, Guid>
    {
        Task<bool> AssignPrincipal(Guid id, Guid principalId);
        Task<bool> VerifySubDomainIsUnique(string subDomain);
    }
}