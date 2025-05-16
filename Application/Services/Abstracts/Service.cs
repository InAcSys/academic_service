using AcademicService.Application.Services.Interfaces;
using AcademicService.Domain.Entities.Abstracts;
using AcademicService.Infrastructure.Repositories.Interfaces;

namespace AcademicService.Application.Services.Abstracts
{
    public abstract class Service<T, TKey>(
        IRepository<T, TKey> repository
    ) : IService<T, TKey> where T : Entity<TKey>
    {
        protected readonly IRepository<T, TKey> _repository = repository;

        public async Task<T?> Create(T entity)
        {
            var result = await _repository.Create(entity);
            return result;
        }

        public async Task<bool> Delete(TKey id)
        {
            var result = await _repository.Delete(id);
            return result;
        }

        public async Task<IEnumerable<T>> GetAll(int pageNumber, int pageSize)
        {
            var result = await _repository.GetAll(pageNumber, pageSize);
            return result;
        }

        public async Task<T?> GetById(TKey id)
        {
            var result = await _repository.GetById(id);
            return result;
        }

        public async Task<T> Update(TKey id, T entity)
        {
            var result = await _repository.Update(id, entity);
            return result;
        }
    }
}