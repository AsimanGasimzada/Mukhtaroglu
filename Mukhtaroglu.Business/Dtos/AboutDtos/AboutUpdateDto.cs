using Microsoft.AspNetCore.Http;
using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class AboutUpdateDto : IDto
{
    public int Id { get; set; }
    public int Order { get; set; }
    public IFormFile? Image { get; set; }
    public string? ImagePath { get; set; }
    public List<AboutLanguageUpdateDto> AboutLanguages { get; set; } = [];
}