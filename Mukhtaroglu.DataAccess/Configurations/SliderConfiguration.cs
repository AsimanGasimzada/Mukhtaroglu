using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mukhtaroglu.Core.Entities;

namespace Mukhtaroglu.DataAccess.Configurations;

internal class SliderConfiguration : IEntityTypeConfiguration<Slider>
{
    public void Configure(EntityTypeBuilder<Slider> builder)
    {
        builder.Property(x => x.ImagePath).IsRequired().HasMaxLength(512);
        builder.Property(x => x.Url).IsRequired(false).HasMaxLength(512);
    }
}
