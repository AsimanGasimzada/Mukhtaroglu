using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;
public class Product : BaseAuditableEntity
{
    public string ImagePath { get; set; } = null!;
    public string? Url { get; set; }
    public ICollection<ProductLanguage> ProductLanguages { get; set; } = [];
}
