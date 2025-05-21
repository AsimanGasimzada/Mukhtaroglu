namespace Mukhtaroglu.Business.Profiles;

internal class EmployeeLanguageProfile : Profile
{
    public EmployeeLanguageProfile()
    {
        CreateMap<EmployeeLanguage, EmployeeLanguageCreateDto>().ReverseMap();
        CreateMap<EmployeeLanguage, EmployeeLanguageUpdateDto>().ReverseMap();
    }
}