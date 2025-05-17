using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mukhtaroglu.DataAccess.Configurations;

internal class SettingLanguageConfiguration : IEntityTypeConfiguration<SettingLanguage>
{
    public void Configure(EntityTypeBuilder<SettingLanguage> builder)
    {
        builder.Property(x => x.Value).IsRequired().HasMaxLength(1000);

        builder.HasIndex(x => new { x.SettingId, x.LanguageId }).IsUnique();
    }
}