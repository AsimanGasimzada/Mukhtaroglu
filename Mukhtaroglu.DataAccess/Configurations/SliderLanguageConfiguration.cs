using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mukhtaroglu.Core.Entities;

namespace Mukhtaroglu.DataAccess.Configurations;

internal class SliderLanguageConfiguration : IEntityTypeConfiguration<SliderLanguage>
{
    public void Configure(EntityTypeBuilder<SliderLanguage> builder)
    {
        builder.Property(x => x.Title).IsRequired().HasMaxLength(512);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(512);

        builder.HasIndex(x => new { x.SliderId, x.LanguageId }).IsUnique();
    }
}
