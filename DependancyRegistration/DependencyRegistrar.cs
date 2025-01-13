using WebApplication6.Factories;
using WebApplication6.Repositories.StudentRepo;
using WebApplication6.repository.GenericRepository;
using WebApplication6.repository.UnitOfWorks;
using WebApplication6.Services;

namespace WebApplication6.DependancyRegistration
{
    public class DependencyRegistrar
    {

        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            //Common
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            //Repository
            services.AddScoped(typeof(IStudentRepository), typeof(StudentRepository));

            //Service
            services.AddScoped(typeof(IStudentService), typeof(StudentService));

            //Factory
            services.AddScoped(typeof(IStudentFactory), typeof(StudentFactory));
        }
    }
}
