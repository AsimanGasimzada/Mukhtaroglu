using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mukhtaroglu.Core.Entities;

namespace Mukhtaroglu.DataAccess.Configurations;
internal class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Code).IsRequired().HasMaxLength(10);
        builder.Property(x => x.Icon).IsRequired().HasMaxLength(50);
    }
}
