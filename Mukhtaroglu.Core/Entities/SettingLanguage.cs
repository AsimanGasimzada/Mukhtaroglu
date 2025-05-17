using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;

public class SettingLanguage : BaseEntity
{
    public string Value { get; set; } = null!;
    public int SettingId { get; set; }
    public Setting Setting { get; set; } = null!;
    public int LanguageId { get; set; }
    public Language Language { get; set; } = null!;
}