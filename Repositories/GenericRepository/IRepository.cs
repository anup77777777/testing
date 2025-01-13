using WebApplication6.repository.UnitOfWorks;

namespace WebApplication6.repository.GenericRepository
{
    public interface IRepository<T>: IUnitOfWork where T : class 
    {
        Task AddAsync(T entity);
        Task<T> GetByIdAsync(int id);
    }
}

