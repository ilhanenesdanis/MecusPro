using MecusPro.Domain.Models.BaseModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MecusPro.Persistence.Configurations
{
    public abstract class BaseConfigurations<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreateDate).ValueGeneratedOnAdd();
            builder.Property(x => x.UniqId).ValueGeneratedOnAdd();
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        }
    }
}
