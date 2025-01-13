using repository_soft.Modules;

namespace WebApplication6.Services
{
    public interface IStudentService
    {
        Task<Student> GetStudentByIdAsync(int id);
    }
}
