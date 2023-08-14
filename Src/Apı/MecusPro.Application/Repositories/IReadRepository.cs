using MecusPro.Domain.Models.BaseModel;
using System.Linq.Expressions;

namespace MecusPro.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> GetAll();
        IQueryable<T> GetBy(Expression<Func<T, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        bool Any(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
        int Count(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(int id);
        T GetById(int id);
        Task<T> GetByGuidAsync(Guid id);
        T GetByGuid(Guid id);
    }
}
