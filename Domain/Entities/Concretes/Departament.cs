using AcademicService.Domain.Entities.Abstracts;

namespace AcademicService.Domain.Entities.Concretes
{
    public class Departament : Entity<int>
    {
        public string Name { get; set; } = "";
        public int Country { get; set; }
    }
}