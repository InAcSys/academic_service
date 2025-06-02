using AcademicService.Application.Services.Interfaces;
using AcademicService.Domain.Entities.Concretes;
using AcademicService.Infrastructure.Repositories.Interfaces;

namespace AcademicService.Application.Services.Abstracts
{
    public abstract class AbstractInstituteService(
        IInstituteRepository repository
    ) : Service<Institute, Guid>(repository), IInstituteService
    {
        protected readonly IInstituteRepository _instituteRepository = repository;
        public async Task<bool> AssignPrincipal(Guid id, Guid principalId)
        {
            var result = await _instituteRepository.AssignPrincipal(id, principalId);
            return result;
        }

        public async Task<bool> VerifySubDomainIsUnique(string subDomain)
        {
            var result = await _instituteRepository.VerifySubDomainIsUnique(subDomain);
            return result;
        }
    }
}