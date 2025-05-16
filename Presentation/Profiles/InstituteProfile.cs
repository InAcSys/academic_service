using AcademicService.Domain.DTOs.Institute;
using AcademicService.Domain.Entities.Concretes;
using AutoMapper;

namespace AcademicService.Presentation.Profiles
{
    public class InstituteProfile : Profile
    {
        public InstituteProfile()
        {
            CreateMap<Institute, CreateInstituteDTO>().ReverseMap();
            CreateMap<Institute, UpdateInstituteDTO>().ReverseMap();
        }
    }
}