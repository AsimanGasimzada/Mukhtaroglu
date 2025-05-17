using Microsoft.AspNetCore.Http;
using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class ServiceUpdateDto : IDto
{
    public int Id { get; set; }
    public IFormFile? Image { get; set; }
    public string? ImagePath { get; set; }
    public List<ServiceLanguageUpdateDto> ServiceLanguages { get; set; } = [];
}