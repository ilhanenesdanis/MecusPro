using MecusPro.Application.Repositories;
using MecusPro.Domain.Models.BaseModel;
using MecusPro.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MecusPro.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _context;

        public ReadRepository(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public bool Any(Expression<Func<T, bool>> predicate)
        {
            return Table.Any(predicate);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return Table.Count(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.CountAsync(predicate);
        }

        public IEnumerable<T> GetAll(bool asNoTracing = false)
        {
            var query = Table.AsQueryable();
            if (asNoTracing)
                query = query.AsNoTracking();

            return query.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync(bool asNoTracing = false)
        {
            var query = Table.AsQueryable();
            if (asNoTracing)
                query = query.AsNoTracking();
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllWithIncludesAsync(bool asNoTracing = false, params Expression<Func<T, object>>[] includes)
        {
            var query = Table.AsQueryable();

            ApplyInclude(query, includes);

            if (asNoTracing)
                query = query.AsNoTracking();

            return await query.ToListAsync();
        }

        public IQueryable<T> GetBy(Expression<Func<T, bool>> predicate, bool asNoTracing = false)
        {
            var query = Table.Where(predicate).AsQueryable();

            if (asNoTracing)
                query = query.AsNoTracking();

            return query;
        }

        public T GetByGuid(Guid id, bool asNoTracing = false)
        {
            var entity = Table.AsQueryable();

            if (asNoTracing)
                entity = entity.AsNoTracking();

            return entity.SingleOrDefault(x => x.UniqId == id);
        }

        public async Task<T> GetByGuidAsync(Guid id, bool asNoTracing = false)
        {
            var entity = Table.AsQueryable();

            if (asNoTracing)
                entity = entity.AsNoTracking();

            return await entity.SingleOrDefaultAsync(x => x.UniqId == id);
        }

        public T GetById(int id, bool asNoTracing = false)
        {
            var entity = Table.AsQueryable();

            if (asNoTracing)
                entity = entity.AsNoTracking();

            return entity.SingleOrDefault(x => x.Id == id);
        }

        public async Task<T> GetByIdAsync(int id, bool asNoTracing = false)
        {
            var entity = Table.AsQueryable();

            if (asNoTracing)
                entity = entity.AsNoTracking();

            return await entity.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<T> GetSingleWithIncludeAsync(Expression<Func<T, bool>> predicate, bool asNoTracing = false, params Expression<Func<T, object>>[] includes)
        {
            var query = Table.Where(predicate);
            if (asNoTracing)
                query = query.AsNoTracking();

            ApplyInclude(query, includes);

            return await query.FirstOrDefaultAsync();
        }
        private static IQueryable<T> ApplyInclude(IQueryable<T> query, params Expression<Func<T, object>>[] ıncludes)
        {
            if (ıncludes != null && ıncludes.Any())
            {
                foreach (var ınclude in ıncludes)
                {
                    query = query.Include(ınclude);
                }
            }
            return query;
        }

    }
}
