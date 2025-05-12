using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mukhtaroglu.Core.Entities;

namespace Mukhtaroglu.DataAccess.Configurations;

internal class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.Property(x => x.ImagePath).IsRequired().HasMaxLength(512);
    }
}
