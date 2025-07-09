using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;

public class ProductLanguage : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Category { get; set; } = null!;
    public Product Product { get; set; } = null!;
    public Language Language { get; set; } = null!;
    public int LanguageId { get; set; } 
    public int ProductId { get; set; } 
}