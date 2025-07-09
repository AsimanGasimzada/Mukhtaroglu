using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mukhtaroglu.DataAccess.Configurations;
internal class AboutConfiguration : IEntityTypeConfiguration<About>
{
    public void Configure(EntityTypeBuilder<About> builder)
    {
        builder.Property(x => x.ImagePath).IsRequired().HasMaxLength(512);
        builder.Property(x => x.Order).IsRequired();

        builder.ToTable(t => t.HasCheckConstraint("CK_Abouts_Order_Constraint", "[Order] >= 0"));
    }
}