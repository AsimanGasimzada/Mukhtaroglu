using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mukhtaroglu.DataAccess.Configurations;
internal class FAQConfiguration : IEntityTypeConfiguration<FAQ>
{
    public void Configure(EntityTypeBuilder<FAQ> builder)
    {
        builder.Property(x => x.Order).IsRequired();
        builder.Property(x => x.IsActive).HasDefaultValue(true);

        builder.ToTable(t => t.HasCheckConstraint("CK_FAQs_Order_Constraint", "[Order] >= 0 "));

    }
}