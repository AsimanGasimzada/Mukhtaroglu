using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class SettingCreateDto : IDto
{
    public string Key { get; set; } = null!;
    public List<SettingLanguageCreateDto> SettingLanguages { get; set; } = [];
}
