using AcademicService.Domain.Entities.Abstracts;

namespace AcademicService.Domain.Entities.Concretes
{
    public class Period : Entity<int>
    {
        public string Name { get; set; } = "";
        public decimal MonthsDuration { get; set; }
    }
}