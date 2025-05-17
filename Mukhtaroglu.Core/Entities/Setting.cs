using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;
public class Setting : BaseEntity
{
    public string Key { get; set; } = null!;
    public ICollection<SettingLanguage> SettingLanguages { get; set; } = new List<SettingLanguage>();
}