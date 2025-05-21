using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mukhtaroglu.DataAccess.Configurations;
internal class RecommendationConfiguration : IEntityTypeConfiguration<Recommendation>
{
    public void Configure(EntityTypeBuilder<Recommendation> builder)
    {
        builder.ToTable(t => t.HasCheckConstraint("CK_Recommendations_Rating_Constraint", "[Rating] >= 0 AND [Rating] <= 5"));
    }
}