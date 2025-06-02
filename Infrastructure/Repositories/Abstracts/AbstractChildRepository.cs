using AcademicService.Domain.Entities.Abstracts;
using AcademicService.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AcademicService.Infrastructure.Repositories.Abstracts
{
    public abstract class AbstractChildRepository<T, TKey, TKeyParent>(
        DbContext context
    ) : Repository<T, TKey>(context), IChildRepository<T, TKey, TKeyParent> where T : ChildEntity<TKey, TKeyParent>
    {
        public async Task<IEnumerable<T>> GetAllByParentId(TKeyParent parentId)
        {
            var entities = await _context
                .Set<T>()
                .Where(x => Equals(x.ParentId, parentId))
                .ToListAsync();

            return entities;
        }
    }
}