using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;

public class Service : BaseEntity
{
    public string ImagePath { get; set; } = null!;
    public ICollection<ServiceLanguage> ServiceLanguages { get; set; } = [];

}
