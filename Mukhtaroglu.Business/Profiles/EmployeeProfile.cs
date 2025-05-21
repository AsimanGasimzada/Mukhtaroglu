using Microsoft.IdentityModel.Tokens;

namespace Mukhtaroglu.Business.Profiles;
internal class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<Employee, EmployeeCreateDto>().ReverseMap();
        CreateMap<EmployeeUpdateDto, Employee>()
            .ForMember(dest => dest.PhoneNumber,
                       opt => opt.MapFrom((src, dest) =>
                           string.IsNullOrEmpty(src.PhoneNumber) ? dest.PhoneNumber : src.PhoneNumber))
            .ForMember(x => x.ImagePath, x => x.Ignore()).ReverseMap();

        CreateMap<Employee, EmployeeGetDto>()
            .ForMember(x => x.Fullname, x => x.MapFrom(x => x.EmployeeLanguages.Any() ? x.EmployeeLanguages.FirstOrDefault()!.Fullname : string.Empty))
            .ForMember(x => x.Position, x => x.MapFrom(x => x.EmployeeLanguages.Any() ? x.EmployeeLanguages.FirstOrDefault()!.Position : string.Empty))
            .ForMember(x => x.Description, x => x.MapFrom(x => x.EmployeeLanguages.Any() ? x.EmployeeLanguages.FirstOrDefault()!.Description : string.Empty))
            .ReverseMap();
    }
}