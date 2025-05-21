using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class RecommendationCreateDto : IDto
{
    public int Rating { get; set; }
    public List<RecommendationLanguageCreateDto> RecommendationLanguages { get; set; } = [];
}
