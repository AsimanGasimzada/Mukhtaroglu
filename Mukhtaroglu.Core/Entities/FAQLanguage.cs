using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;

public class FAQLanguage : BaseEntity
{
    public string Topic { get; set; } = null!;
    public string Question { get; set; } = null!;
    public string Answer { get; set; } = null!;
    public int FAQId { get; set; }
    public FAQ FAQ { get; set; } = null!;
    public Language Language { get; set; } = null!;
    public int LanguageId { get; set; }
}
