using AutoMapper;

namespace Mukhtaroglu.Business.Profiles;
internal class SliderProfile : Profile
{
    public SliderProfile()
    {
        CreateMap<Slider, SliderCreateDto>().ReverseMap();
        CreateMap<Slider, SliderUpdateDto>().ReverseMap().ForMember(x => x.ImagePath, x => x.Ignore());
        CreateMap<Slider, SliderGetDto>()
                        .ForMember(x => x.Title, x => x.MapFrom(x => x.SliderLanguages.FirstOrDefault() != null ? x.SliderLanguages.FirstOrDefault()!.Title : string.Empty))
                        .ForMember(x => x.Description, x => x.MapFrom(x => x.SliderLanguages.FirstOrDefault() != null ? x.SliderLanguages.FirstOrDefault()!.Description : string.Empty));

    }
}
