using MecusPro.Application.Repositories;
using MecusPro.Domain.Models.BaseModel;
using MecusPro.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace MecusPro.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _context;

        public WriteRepository(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public void Add(T entity)
        {
            Table.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Table.AddRange(entities);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();

        }

        public void Delete(Guid guid)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
