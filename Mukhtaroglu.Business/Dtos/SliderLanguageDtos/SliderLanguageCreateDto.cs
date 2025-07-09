using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;
public class SliderLanguageCreateDto : IDto
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ButtonTitle { get; set; }
    public required int LanguageId { get; set; }
}