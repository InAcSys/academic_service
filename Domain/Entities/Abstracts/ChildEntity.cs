using AcademicService.Domain.Entities.Interfaces;

namespace AcademicService.Domain.Entities.Abstracts
{
    public abstract class ChildEntity<TKey, TKeyParent> : Entity<TKey>, IChildEntity<TKey, TKeyParent>
    {
        public TKeyParent ParentId { get; set; }
    }
}