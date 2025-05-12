using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;

public class ServiceLanguage : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int ServiceId { get; set; }
    public Service Service { get; set; } = null!;
    public int LanguageId { get; set; }
    public Language Language { get; set; } = null!;
}