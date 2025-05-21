using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;
public class FAQ : BaseEntity
{
    public int Order { get; set; }
    public bool IsActive { get; set; } = true;
    public ICollection<FAQLanguage> FAQLanguages { get; set; } = [];
}