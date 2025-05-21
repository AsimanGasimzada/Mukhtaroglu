using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class RecommendationLanguageUpdateDto : IDto
{
    public string Author { get; set; } = null!;
    public string Profession { get; set; } = null!;
    public string Title { get; set; } = null!;
    public int LanguageId { get; set; }
}
