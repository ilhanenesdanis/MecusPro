using MecusPro.Domain.Models.BaseModel;
using Microsoft.EntityFrameworkCore;

namespace MecusPro.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        DbSet<T> Table { get; }
    }
}
