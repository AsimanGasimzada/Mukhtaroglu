using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mukhtaroglu.Core.Entities;

namespace Mukhtaroglu.DataAccess.Configurations;

internal class ServiceLanguageConfiguration : IEntityTypeConfiguration<ServiceLanguage>
{
    public void Configure(EntityTypeBuilder<ServiceLanguage> builder)
    {
        builder.Property(x => x.Name).IsRequired().HasMaxLength(512);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(512);

        builder.HasIndex(x => new { x.ServiceId, x.LanguageId }).IsUnique();
    }
}
