using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class FAQLanguageUpdateDto : IDto
{
    public string Topic { get; set; } = null!;
    public string Question { get; set; } = null!;
    public string Answer { get; set; } = null!;
    public int LanguageId { get; set; }
}