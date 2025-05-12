using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;
public class Slider : BaseAuditableEntity
{
    public string ImagePath { get; set; } = null!;
    public string Url { get; set; } = null!;
    public ICollection<SliderLanguage> SliderLanguages { get; set; } = [];
}
