using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class FAQGetDto : IDto
{
    public int Id { get; set; }
    public int Order { get; set; }
    public bool IsActive { get; set; }
    public string Topic { get; set; } = null!;
    public string Question { get; set; } = null!;
    public string Answer { get; set; } = null!;
}
