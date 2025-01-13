using repository_soft.Modules;
using WebApplication6.Data;
using WebApplication6.repository.GenericRepository;

namespace WebApplication6.Repositories.StudentRepo
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
            
    }

}
