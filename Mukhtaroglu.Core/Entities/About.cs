using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;
public class About : BaseEntity
{
    public int Order { get; set; }
    public string ImagePath { get; set; } = null!;
    public List<AboutLanguage> AboutLanguages { get; set; } = [];
}