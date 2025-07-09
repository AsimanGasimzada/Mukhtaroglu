using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class FAQDto : IDto
{
    public List<FAQGetDto> FAQs { get; set; } = [];
    public Dictionary<string, string> Settings { get; set; } = [];
}
