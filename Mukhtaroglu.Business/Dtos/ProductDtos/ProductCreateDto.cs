using Microsoft.AspNetCore.Http;
using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;
public class ProductCreateDto : IDto
{
    public IFormFile Image { get; set; } = null!;
    public string? Url { get; set; }
    public List<ProductLanguageCreateDto> ProductLanguages { get; set; } = [];
}
