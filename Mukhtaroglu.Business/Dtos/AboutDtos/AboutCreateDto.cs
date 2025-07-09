using Microsoft.AspNetCore.Http;
using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;
public class AboutCreateDto : IDto
{
    public int Order { get; set; }
    public IFormFile Image { get; set; } = null!;
    public List<AboutLanguageCreateDto> AboutLanguages { get; set; } = [];
}