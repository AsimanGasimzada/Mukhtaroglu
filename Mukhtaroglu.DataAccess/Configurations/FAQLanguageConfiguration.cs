using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mukhtaroglu.DataAccess.Configurations;

internal class FAQLanguageConfiguration : IEntityTypeConfiguration<FAQLanguage>
{
    public void Configure(EntityTypeBuilder<FAQLanguage> builder)
    {
        builder.Property(x => x.Question).IsRequired().HasMaxLength(2000);
        builder.Property(x => x.Answer).IsRequired().HasMaxLength(5000);
        builder.Property(x => x.Topic).IsRequired().HasMaxLength(64);

        builder.HasIndex(x => new { x.FAQId, x.LanguageId }).IsUnique();
    }
}