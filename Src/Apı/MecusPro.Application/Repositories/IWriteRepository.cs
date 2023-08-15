using MecusPro.Domain.Models.BaseModel;

namespace MecusPro.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        Task AddAsync(T entity);
        void Add(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void AddRange(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        void Update(T entity);
        Task UpdateRangeAsync(IEnumerable<T> entities);
        void UpdateRange(IEnumerable<T> entities);
        void Delete(int id);
        Task DeleteAsync(int id);
        void Delete(Guid guid);
        Task DeleteAsync(Guid guid);
        Task DeleteAsync(T entity);
        void Delete(T entity);
    }
}
