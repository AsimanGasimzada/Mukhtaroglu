using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class SliderLanguageUpdateDto : IDto
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required int LanguageId { get; set; }
}
