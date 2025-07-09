using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mukhtaroglu.DataAccess.Configurations;

internal class ProductLanguageConfiguration : IEntityTypeConfiguration<ProductLanguage>
{
    public void Configure(EntityTypeBuilder<ProductLanguage> builder)
    {
        builder.HasKey(x => new { x.ProductId, x.LanguageId });
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Category).IsRequired().HasMaxLength(100);

        builder.HasIndex(x => new { x.ProductId, x.LanguageId }).IsUnique();
    }
}