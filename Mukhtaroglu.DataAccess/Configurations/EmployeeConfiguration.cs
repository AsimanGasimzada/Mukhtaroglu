using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mukhtaroglu.DataAccess.Configurations;
internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(x => x.ImagePath).IsRequired().HasMaxLength(1000);
        builder.Property(x => x.EmailAddress).IsRequired().HasMaxLength(256);
        builder.Property(x => x.PhoneNumber).IsRequired(false).HasMaxLength(256);
    }
}