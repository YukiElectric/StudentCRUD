using AutoMapper;
using StudentCRUD.Data;
using StudentCRUD.Models;

namespace StudentCRUD.Common
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Student, StudentModel>().ReverseMap();
        }
    }
}
