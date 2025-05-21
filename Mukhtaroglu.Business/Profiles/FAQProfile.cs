namespace Mukhtaroglu.Business.Profiles;
internal class FAQProfile : Profile
{
    public FAQProfile()
    {
        CreateMap<FAQ, FAQCreateDto>().ReverseMap();
        CreateMap<FAQ, FAQUpdateDto>().ReverseMap();
        CreateMap<FAQ, FAQGetDto>()
            .ForMember(x => x.Topic, x => x.MapFrom(x => x.FAQLanguages.Any() ? x.FAQLanguages.FirstOrDefault()!.Topic : string.Empty))
            .ForMember(x => x.Question, x => x.MapFrom(x => x.FAQLanguages.Any() ? x.FAQLanguages.FirstOrDefault()!.Question : string.Empty))
            .ForMember(x => x.Answer, x => x.MapFrom(x => x.FAQLanguages.Any() ? x.FAQLanguages.FirstOrDefault()!.Answer : string.Empty))
            .ReverseMap();
    }
}