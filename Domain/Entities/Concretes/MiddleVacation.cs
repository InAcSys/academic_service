using AcademicService.Domain.Entities.Abstracts;

namespace AcademicService.Domain.Entities.Concretes
{
    public class MiddleVacation : Entity<int>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}