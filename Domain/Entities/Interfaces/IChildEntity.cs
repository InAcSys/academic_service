namespace AcademicService.Domain.Entities.Interfaces
{
    public interface IChildEntity<TKey, TKeyParent> : IEntity<TKey>
    {
        TKeyParent ParentId { get; set; }
    }
}