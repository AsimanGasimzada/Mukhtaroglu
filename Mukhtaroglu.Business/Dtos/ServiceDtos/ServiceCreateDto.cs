using Microsoft.AspNetCore.Http;
using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class ServiceCreateDto : IDto
{
    public IFormFile Image { get; set; } = null!;
    public List<ServiceLanguageCreateDto> ServiceLanguages { get; set; } = [];
}
