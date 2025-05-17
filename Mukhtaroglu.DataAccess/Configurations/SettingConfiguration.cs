using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mukhtaroglu.DataAccess.Configurations;
internal class SettingConfiguration : IEntityTypeConfiguration<Setting>
{
    public void Configure(EntityTypeBuilder<Setting> builder)
    {
        builder.Property(x => x.Key).IsRequired().HasMaxLength(100);

        builder.HasIndex(x => x.Key).IsUnique();

    }
}