using AutoMapper;
using SwiftEd.Dtos;
using SwiftEd.Models;

namespace SwiftEd.ProfileMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Admin , AdminDto>().ReverseMap();
            CreateMap<Admin , CreateAdminRequestModel>().ReverseMap();
            CreateMap<User , CreateAdminRequestModel>().ReverseMap();
            CreateMap<Course , CourseDto>().ReverseMap();
            CreateMap<CourseMaterial , CourseMaterialDto>().ReverseMap();
            CreateMap<Student , StudentDto>().ReverseMap();
            CreateMap<Lecturer , LecturerDto>().ReverseMap();
            CreateMap<Role , RoleDto>().ReverseMap();
            CreateMap<User , UserDto>().ReverseMap();
        }
    }
}