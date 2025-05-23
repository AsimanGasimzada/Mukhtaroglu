namespace Mukhtaroglu.Business.Profiles;
internal class RecommendationProfile : Profile
{
    public RecommendationProfile()
    {
        CreateMap<Recommendation, RecommendationCreateDto>().ReverseMap();
        CreateMap<Recommendation, RecommendationUpdateDto>().ReverseMap();

        CreateMap<Recommendation, RecommendationGetDto>()
            .ForMember(x => x.Author, x => x.MapFrom(x => x.RecommendationLanguages.Any() ? x.RecommendationLanguages.FirstOrDefault()!.Author : string.Empty))
            .ForMember(x => x.Title, x => x.MapFrom(x => x.RecommendationLanguages.Any() ? x.RecommendationLanguages.FirstOrDefault()!.Title : string.Empty))
            .ForMember(x => x.Profession, x => x.MapFrom(x => x.RecommendationLanguages.Any() ? x.RecommendationLanguages.FirstOrDefault()!.Profession : string.Empty));
    }
}