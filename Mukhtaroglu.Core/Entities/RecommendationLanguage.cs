using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;

public class RecommendationLanguage : BaseEntity
{
    public string Author { get; set; } = null!;
    public string Profession { get; set; } = null!;
    public string Title { get; set; } = null!;
    public int RecommendationId { get; set; }
    public Recommendation Recommendation { get; set; } = null!;
    public int LanguageId { get; set; }
    public Language Language { get; set; } = null!;
}


