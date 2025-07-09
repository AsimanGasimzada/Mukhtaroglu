using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;

public class AboutLanguage : BaseEntity
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public Language Language { get; set; } = null!;
    public int LanguageId { get; set; }
    public About About { get; set; } = null!;
    public int AboutId { get; set; }

}
