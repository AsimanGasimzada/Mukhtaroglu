using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mukhtaroglu.DataAccess.Configurations;

public class AboutLanguageConfiguration : IEntityTypeConfiguration<AboutLanguage>
{
    public void Configure(EntityTypeBuilder<AboutLanguage> builder)
    {
        builder.Property(x => x.Title).IsRequired().HasMaxLength(256);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(5000);

        builder.HasIndex(x => new { x.LanguageId, x.AboutId }).IsUnique();
    }
}
