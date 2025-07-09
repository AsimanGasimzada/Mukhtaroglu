namespace Mukhtaroglu.Business.Profiles;

internal class AboutLanguageProfile : Profile
{
    public AboutLanguageProfile()
    {
        CreateMap<AboutLanguage, AboutLanguageCreateDto>().ReverseMap();
        CreateMap<AboutLanguage, AboutLanguageUpdateDto>().ReverseMap();
    }
}