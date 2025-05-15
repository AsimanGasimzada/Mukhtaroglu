using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;
public class SliderGetDto : IDto
{
    public int Id { get; set; }
    public int ViewCount { get; set; }
    public required string ImagePath { get; set; }
    public required string Url { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
}