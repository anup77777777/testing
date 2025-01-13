namespace WebApplication6.repository.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        Task CommitAsync();
    }
}
