using AcademicService.Application.Services.Interfaces;
using AcademicService.Domain.Entities.Abstracts;
using AcademicService.Infrastructure.Repositories.Interfaces;

namespace AcademicService.Application.Services.Abstracts
{
    public abstract class AbstractChildService<T, TKey, TKeyParent>
    (
        IChildRepository<T, TKey, TKeyParent> repository
    ) : Service<T, TKey>(repository), IChildService<T, TKey, TKeyParent> where T : ChildEntity<TKey, TKeyParent>
    {
        private readonly IChildRepository<T, TKey, TKeyParent> _repository = repository;
        public async Task<IEnumerable<T>> GetAllByParentId(TKeyParent parentId)
        {
            var result = await _repository.GetAllByParentId(parentId);
            return result;
        }
    }
}