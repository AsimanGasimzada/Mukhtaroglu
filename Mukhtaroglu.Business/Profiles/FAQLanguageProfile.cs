namespace Mukhtaroglu.Business.Profiles;

internal class FAQLanguageProfile : Profile
{
    public FAQLanguageProfile()
    {
        CreateMap<FAQLanguage, FAQLanguageCreateDto>().ReverseMap();
        CreateMap<FAQLanguage, FAQLanguageUpdateDto>().ReverseMap();
    }
}