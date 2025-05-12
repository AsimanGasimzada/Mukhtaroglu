using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;

public class SliderLanguage : BaseEntity
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int SliderId { get; set; }
    public Slider Slider { get; set; } = null!;
    public int LanguageId { get; set; }
    public Language Language { get; set; } = null!;
}
