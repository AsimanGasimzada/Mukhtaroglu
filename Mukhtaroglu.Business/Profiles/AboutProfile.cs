namespace Mukhtaroglu.Business.Profiles;
internal class AboutProfile : Profile
{
    public AboutProfile()
    {
        CreateMap<About, AboutCreateDto>().ReverseMap();
        CreateMap<About, AboutUpdateDto>().ReverseMap().ForMember(x => x.ImagePath, x => x.Ignore());

        CreateMap<About, AboutGetDto>()
            .ForMember(x => x.Title, x => x.MapFrom(x => x.AboutLanguages.Any() ? x.AboutLanguages.FirstOrDefault()!.Title : string.Empty))
            .ForMember(x => x.Description, x => x.MapFrom(x => x.AboutLanguages.Any() ? x.AboutLanguages.FirstOrDefault()!.Description : string.Empty))
            .ReverseMap();
    }
}