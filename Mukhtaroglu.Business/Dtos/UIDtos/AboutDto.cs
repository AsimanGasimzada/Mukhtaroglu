using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class AboutDto : IDto
{
    public List<AboutGetDto> Abouts { get; set; } = [];
    public Dictionary<string, string> Settings { get; set; } = [];
}
