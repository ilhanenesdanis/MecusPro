using MecusPro.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MecusPro.Persistence.Configurations
{
    public class ProductColorConfiguration:BaseConfigurations<ProductColor>
    {
        public override void Configure(EntityTypeBuilder<ProductColor> builder)
        {
            base.Configure(builder);

            builder.HasIndex(x => new { x.ProductId, x.ColorId });
            builder.HasOne(x=>x.Product).WithMany(x=>x.ProductColors).HasForeignKey(x=>x.ProductId);
            builder.HasOne(x=>x.Color).WithMany(x=>x.ProductColors).HasForeignKey(x=>x.ColorId);


        }
    }
}
