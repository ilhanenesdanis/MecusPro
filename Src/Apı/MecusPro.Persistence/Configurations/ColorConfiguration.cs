using MecusPro.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MecusPro.Persistence.Configurations
{
    public class ColorConfiguration:BaseConfigurations<Color>
    {
        public override void Configure(EntityTypeBuilder<Color> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.ColorName).IsRequired();
            
            builder.HasOne(x => x.Languages).WithMany(x => x.Colors).HasForeignKey(x => x.LanguageId);
            
        }
    }
}
