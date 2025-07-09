using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;

public class SliderLanguage : BaseEntity
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ButtonTitle { get; set; }
    public int SliderId { get; set; }
    public Slider Slider { get; set; } = null!;
    public int LanguageId { get; set; }
    public Language Language { get; set; } = null!;
}
