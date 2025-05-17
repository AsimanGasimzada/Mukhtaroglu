using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class ServiceLanguageUpdateDto : IDto
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int LanguageId { get; set; }
}
