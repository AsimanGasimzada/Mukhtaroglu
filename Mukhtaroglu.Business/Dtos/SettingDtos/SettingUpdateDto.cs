using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class SettingUpdateDto : IDto
{
    public int Id { get; set; }
    public string? Key { get; set; }
    public List<SettingLanguageUpdateDto> SettingLanguages { get; set; } = [];
}