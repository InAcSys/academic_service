namespace AcademicService.Application.Services.Interfaces
{
    public interface IChildService<T, TKey, TKeyParent> : IService<T, TKey>
    {
        Task<IEnumerable<T>> GetAllByParentId(TKeyParent parentId);
    }
}