using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class RecommendationUpdateDto : IDto
{
    public int Id { get; set; }
    public int Rating { get; set; }
    public List<RecommendationLanguageUpdateDto> RecommendationLanguages { get; set; } = [];
}
