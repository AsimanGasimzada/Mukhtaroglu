namespace Mukhtaroglu.Business.Profiles;
internal class SettingProfile : Profile
{
    public SettingProfile()
    {
        CreateMap<Setting, SettingGetDto>()
            .ForMember(dest => dest.Value, opt => opt.MapFrom(x => x.SettingLanguages.Any() ? x.SettingLanguages.FirstOrDefault()!.Value : string.Empty))
            .ReverseMap();
        CreateMap<Setting, SettingCreateDto>().ReverseMap();
        CreateMap<Setting, SettingUpdateDto>().ForMember(x => x.Key, x => x.Ignore()).ReverseMap();
    }
}