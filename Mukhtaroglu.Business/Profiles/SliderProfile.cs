namespace Mukhtaroglu.Business.Profiles;
internal class SliderProfile : Profile
{
    public SliderProfile()
    {
        CreateMap<Slider, SliderCreateDto>().ReverseMap();
        CreateMap<Slider, SliderUpdateDto>().ReverseMap().ForMember(x => x.ImagePath, x => x.Ignore());
        CreateMap<Slider, SliderGetDto>()
                        .ForMember(x => x.Title, x => x.MapFrom(x => x.SliderLanguages.Any() ? x.SliderLanguages.FirstOrDefault()!.Title : string.Empty))
                        .ForMember(x => x.ButtonTitle, x => x.MapFrom(x => x.SliderLanguages.Any() ? x.SliderLanguages.FirstOrDefault()!.ButtonTitle : string.Empty))
                        .ForMember(x => x.Description, x => x.MapFrom(x => x.SliderLanguages.Any() ? x.SliderLanguages.FirstOrDefault()!.Description : string.Empty))
                        .ReverseMap();
    }
}

