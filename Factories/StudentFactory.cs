using repository_soft.Modules;
using WebApplication6.Dto;

namespace WebApplication6.Factories
{
    public class StudentFactory
    {
        public StudentDto MapStudentEntityToDto(Student entity)
        {
            StudentDto dto = new();
            {
                dto.FirstName = entity.FirstName;
                dto.Email = entity.Email;
                dto.Address = entity.Address;
            }
            return dto;
        }
    }
}
