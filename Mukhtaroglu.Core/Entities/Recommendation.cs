using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;
public class Recommendation : BaseEntity
{
    public int Rating { get; set; }
    public ICollection<RecommendationLanguage> RecommendationLanguages { get; set; } = [];
}
