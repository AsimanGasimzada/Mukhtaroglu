using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class EmployeeLanguageUpdateDto : IDto
{
    public string Fullname { get; set; } = null!;
    public string Position { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int LanguageId { get; set; }
}
