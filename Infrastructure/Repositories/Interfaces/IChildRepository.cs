namespace AcademicService.Infrastructure.Repositories.Interfaces
{
    public interface IChildRepository<T, TKey, TKeyParent> : IRepository<T, TKey>
    {
        Task<IEnumerable<T>> GetAllByParentId(TKeyParent parentId);
    }
}