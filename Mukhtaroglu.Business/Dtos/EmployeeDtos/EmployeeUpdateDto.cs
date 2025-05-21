using Microsoft.AspNetCore.Http;
using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class EmployeeUpdateDto : IDto
{
    public int Id { get; set; }
    public IFormFile? Image { get; set; } 
    public string? ImagePath { get; set; }
    public string EmailAddress { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public List<EmployeeLanguageUpdateDto> EmployeeLanguages { get; set; } = [];
}
