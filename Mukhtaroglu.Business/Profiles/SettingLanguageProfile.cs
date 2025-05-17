namespace Mukhtaroglu.Business.Profiles;

internal class SettingLanguageProfile : Profile
{
    public SettingLanguageProfile()
    {
        CreateMap<SettingLanguage, SettingLanguageCreateDto>().ReverseMap();
        CreateMap<SettingLanguage, SettingLanguageUpdateDto>().ReverseMap();
    }
}