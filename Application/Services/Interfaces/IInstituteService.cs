using AcademicService.Domain.Entities.Concretes;

namespace AcademicService.Application.Services.Interfaces
{
    public interface IInstituteService : IService<Institute, Guid>
    {
        Task<bool> AssignPrincipal(Guid id, Guid principalId);
        Task<bool> VerifySubDomainIsUnique(string subDomain);
    }
}