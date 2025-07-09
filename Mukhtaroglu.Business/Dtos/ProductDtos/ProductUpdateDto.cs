using Microsoft.AspNetCore.Http;
using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class ProductUpdateDto : IDto
{
    public int Id { get; set; }
    public string? ImagePath { get; set; }
    public IFormFile? Image { get; set; }
    public string? Url { get; set; }
    public List<ProductLanguageUpdateDto> ProductLanguages { get; set; } = [];
}


