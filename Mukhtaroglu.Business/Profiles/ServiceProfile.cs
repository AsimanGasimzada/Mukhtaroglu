
namespace Mukhtaroglu.Business.Profiles;
internal class ServiceProfile : Profile
{
    public ServiceProfile()
    {
        CreateMap<Service, ServiceCreateDto>().ReverseMap();
        CreateMap<Service, ServiceUpdateDto>().ReverseMap().ForMember(x => x.ImagePath, x => x.Ignore());
        CreateMap<Service, ServiceGetDto>()
            .ForMember(x => x.Name, x => x.MapFrom(x => x.ServiceLanguages.Any() ? x.ServiceLanguages.FirstOrDefault()!.Name : string.Empty))
            .ForMember(x => x.Description, x => x.MapFrom(x => x.ServiceLanguages.Any() ? x.ServiceLanguages.FirstOrDefault()!.Description : string.Empty))
            .ReverseMap();
    }
}