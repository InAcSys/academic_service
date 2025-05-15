namespace AcademicService.Domain.Entities.Interfaces
{
    public interface ITimeStamp
    {
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
    }
}