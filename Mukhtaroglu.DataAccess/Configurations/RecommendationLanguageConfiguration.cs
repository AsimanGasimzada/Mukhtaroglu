using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mukhtaroglu.DataAccess.Configurations;

internal class RecommendationLanguageConfiguration : IEntityTypeConfiguration<RecommendationLanguage>
{
    public void Configure(EntityTypeBuilder<RecommendationLanguage> builder)
    {
        builder.Property(x => x.Title).IsRequired().HasMaxLength(5000);
        builder.Property(x => x.Author).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Profession).IsRequired().HasMaxLength(100);

        builder.HasIndex(x => new { x.RecommendationId, x.LanguageId }).IsUnique();
    }
}