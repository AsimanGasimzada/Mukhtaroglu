using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class AboutLanguageUpdateDto : IDto
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int LanguageId { get; set; }
}