using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;
public class RecommendationGetDto : IDto
{
    public int Id { get; set; }
    public string Author { get; set; } = null!;
    public string Profession { get; set; } = null!;
    public string Title { get; set; } = null!;
    public int Rating { get; set; }
}
