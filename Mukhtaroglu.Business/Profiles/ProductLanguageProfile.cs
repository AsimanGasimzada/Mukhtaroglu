namespace Mukhtaroglu.Business.Profiles;

internal class ProductLanguageProfile : Profile
{
    public ProductLanguageProfile()
    {
        CreateMap<ProductLanguage, ProductLanguageCreateDto>().ReverseMap();
        CreateMap<ProductLanguage, ProductLanguageUpdateDto>().ReverseMap();
    }
}