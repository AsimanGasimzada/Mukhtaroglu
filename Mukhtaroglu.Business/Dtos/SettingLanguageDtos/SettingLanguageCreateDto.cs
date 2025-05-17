using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;
public class SettingLanguageCreateDto : IDto
{
    public string Value { get; set; } = null!;
    public int LanguageId { get; set; }
}