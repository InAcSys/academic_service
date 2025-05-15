using AcademicService.Domain.Entities.Abstracts;

namespace AcademicService.Domain.Entities.Concretes
{
    public class Institute : Entity<Guid>
    {
        public string Name { get; set; } = "";
        public Guid Principal { get; set; }
        public int Type { get; set; }
        public int Nature { get; set; }
        public int Period { get; set; }
        public string SubDomain { get; set; } = "";
        public int Country { get; set; }
        public int Departament { get; set;}
        public int City { get; set; }
        public string Location { get; set; } = "";
        public string Logo { get; set; } = "";
        public int MiddleVacations { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}