using repository_soft.Modules;
using WebApplication6.Dto;

namespace WebApplication6.Factories
{
    public interface IStudentFactory
    {
        StudentDto MapStudentEntityToDto(Student entity);
    }
}
