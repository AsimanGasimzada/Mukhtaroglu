using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class ProductGetDto : IDto
{
    public int Id { get; set; }
    public string ImagePath { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Category { get; set; } = null!;
    public string? Url { get; set; }
}


