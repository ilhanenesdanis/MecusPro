using MecusPro.Domain.Models.BaseModel;
using System.Linq.Expressions;

namespace MecusPro.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        Task<IEnumerable<T>> GetAllAsync(bool asNoTracing = false);
        IEnumerable<T> GetAll(bool asNoTracing = false);
        IQueryable<T> GetBy(Expression<Func<T, bool>> predicate, bool asNoTracing = false);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        bool Any(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate );
        int Count(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(int id, bool asNoTracing = false);
        T GetById(int id, bool asNoTracing = false);
        Task<T> GetByGuidAsync(Guid id, bool asNoTracing = false);
        T GetByGuid(Guid id, bool asNoTracing = false);
        Task<T> GetSingleWithIncludeAsync(Expression<Func<T, bool>> predicate, bool asNoTracing = false, params Expression<Func<T, object>>[] includes);
        Task<IEnumerable<T>> GetAllWithIncludesAsync(bool asNoTracing = false, params Expression<Func<T, object>>[] includes);

    }
}
