using Microsoft.AspNetCore.Http;
using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class EmployeeCreateDto : IDto
{
    public IFormFile Image { get; set; } = null!;
    public string EmailAddress { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public List<EmployeeLanguageCreateDto> EmployeeLanguages { get; set; } = [];
}
