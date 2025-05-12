using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;

public class Language : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Code { get; set; } = null!;
    public string Icon { get; set; } = null!;
}
