using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mukhtaroglu.DataAccess.Configurations;

internal class EmployeeLanguageConfiguration : IEntityTypeConfiguration<EmployeeLanguage>
{
    public void Configure(EntityTypeBuilder<EmployeeLanguage> builder)
    {
        builder.Property(x => x.Fullname).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Position).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(10000);

        builder.HasIndex(x => new { x.EmployeeId, x.LanguageId }).IsUnique();
    }
}