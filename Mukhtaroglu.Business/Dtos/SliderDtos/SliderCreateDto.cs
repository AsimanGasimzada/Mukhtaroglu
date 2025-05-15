using Microsoft.AspNetCore.Http;
using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class SliderCreateDto : IDto
{
    public required IFormFile Image { get; set; }
    public string? Url { get; set; }
    public List<SliderLanguageCreateDto> SliderLanguages { get; set; } = [];
}
