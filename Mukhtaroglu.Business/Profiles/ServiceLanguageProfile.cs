
namespace Mukhtaroglu.Business.Profiles;

internal class ServiceLanguageProfile : Profile
{
    public ServiceLanguageProfile()
    {
        CreateMap<ServiceLanguage, ServiceLanguageCreateDto>().ReverseMap();
        CreateMap<ServiceLanguage, ServiceLanguageUpdateDto>().ReverseMap();
    }
}