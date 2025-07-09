namespace Mukhtaroglu.Business.Profiles;
internal class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductCreateDto>().ReverseMap();
        CreateMap<Product, ProductUpdateDto>().ForMember(x => x.ImagePath, x => x.Ignore()).ReverseMap();

        //CreateMap<Product, ProductGetDto>()
        //    .ForMember(x => x.Name, x => x.MapFrom(x => x.ProductLanguages.Any() ? x.ProductLanguages.FirstOrDefault()!.Name : string.Empty))
        //    .ForMember(x => x.Category, x => x.MapFrom(x => x.ProductLanguages.Any() ? x.ProductLanguages.FirstOrDefault()!.Category : string.Empty))
        //    .ReverseMap();
    }
}