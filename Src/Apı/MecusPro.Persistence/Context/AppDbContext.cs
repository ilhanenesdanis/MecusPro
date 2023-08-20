using MecusPro.Domain.Enums;
using MecusPro.Domain.Models;
using MecusPro.Domain.Models.BaseModel;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MecusPro.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        #region DB Tables

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ConstantValue> ConstantValues { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<MediaFiles> MediaFiles { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuUser> MenuUsers { get; set; }
        public DbSet<SettingGroup> SettingGroups { get; set; }
        public DbSet<SettingsKey> SettingsKeys { get; set; }
        public DbSet<UserAddres> UserAddres { get; set; }


        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            OnBeforeSave();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            OnBeforeSave();
            return base.SaveChangesAsync(cancellationToken);
        }
        private void OnBeforeSave()
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity baseEntity)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                baseEntity.IsDeleted = false;
                                baseEntity.CreateDate = DateTime.Now;
                                baseEntity.Status = (int)StatusEnum.Active;
                                baseEntity.UniqId = Guid.NewGuid();
                                break;
                            }
                        case EntityState.Modified:
                            {
                                baseEntity.UpdateDate = DateTime.Now;
                                break;
                            }
                        default:
                            break;
                    }
                }
            }
        }

    }
}
