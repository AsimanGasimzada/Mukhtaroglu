using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;

public class EmployeeLanguage : BaseEntity
{
    public string Fullname { get; set; } = null!;
    public string Position { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;
    public int LanguageId { get; set; }
    public Language Language { get; set; } = null!;
}
