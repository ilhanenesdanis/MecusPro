using MecusPro.Application.UnitOfWork;
using MecusPro.Persistence.Context;

namespace MecusPro.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public int SaveChanges()
        {
            using (var tran = _context.Database.BeginTransaction())
            {
                try
                {
                    int commit = _context.SaveChanges();
                    tran.Commit();
                    return commit;
                }
                catch (Exception ex)
                {

                    tran.Rollback();
                    return 0;
                }
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            using (var tranAsync = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    int commit = await _context.SaveChangesAsync();
                    await tranAsync.CommitAsync();
                    return commit;
                }
                catch (Exception ex)
                {

                    await tranAsync.RollbackAsync();

                    return 0;
                }
            }
        }
    }
}
