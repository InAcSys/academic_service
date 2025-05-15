using AcademicService.Domain.Entities.Abstracts;

namespace AcademicService.Domain.Entities.Concretes
{
    public class Nature : Entity<int>
    {
        public string Name { get; set; } = "";
    }
}