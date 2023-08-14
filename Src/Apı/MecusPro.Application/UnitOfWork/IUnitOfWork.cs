namespace MecusPro.Application.UnitOfWork
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
