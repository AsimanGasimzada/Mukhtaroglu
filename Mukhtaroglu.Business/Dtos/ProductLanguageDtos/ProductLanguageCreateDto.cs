using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;
public class ProductLanguageCreateDto : IDto
{
    public string Name { get; set; } = null!;
    public string Category { get; set; } = null!;
    public int LanguageId { get; set; }
}