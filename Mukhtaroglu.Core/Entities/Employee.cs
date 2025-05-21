using Mukhtaroglu.Core.Entities.Common;

namespace Mukhtaroglu.Core.Entities;
public class Employee : BaseEntity
{
    public string ImagePath { get; set; } = null!;
    public string EmailAddress { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public ICollection<EmployeeLanguage> EmployeeLanguages { get; set; } = [];
}