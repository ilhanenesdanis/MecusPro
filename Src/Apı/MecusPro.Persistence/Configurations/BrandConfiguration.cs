using MecusPro.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MecusPro.Persistence.Configurations
{
    public class BrandConfiguration : BaseConfigurations<Brand>
    {
        public override void Configure(EntityTypeBuilder<Brand> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(300);
        }
    }
}
