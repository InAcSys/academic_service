namespace AcademicService.Domain.Entities.Interfaces
{
    public interface IEntity<TKey> : ITimeStamp
    {
        public TKey? Id { get; set; }
        public bool IsActive { get; set; }
    }
}