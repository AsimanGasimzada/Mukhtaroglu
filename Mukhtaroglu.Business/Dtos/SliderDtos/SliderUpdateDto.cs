using Microsoft.AspNetCore.Http;
using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class SliderUpdateDto : IDto
{
    public int Id { get; set; }
    public string? ImagePath { get; set; }
    public required string Url { get; set; }
    public IFormFile? Image { get; set; }
    public List<SliderLanguageUpdateDto> SliderLanguages { get; set; } = [];
}