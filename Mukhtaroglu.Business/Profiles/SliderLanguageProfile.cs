using AutoMapper;

namespace Mukhtaroglu.Business.Profiles;
internal class SliderLanguageProfile : Profile
{
    public SliderLanguageProfile()
    {
        CreateMap<SliderLanguage, SliderLanguageCreateDto>().ReverseMap();
        CreateMap<SliderLanguage, SliderLanguageUpdateDto>().ReverseMap();
    }
}
