namespace Mukhtaroglu.Business.Profiles;

internal class RecommendationLanguageProfile : Profile
{
    public RecommendationLanguageProfile()
    {
        CreateMap<RecommendationLanguage, RecommendationLanguageCreateDto>().ReverseMap();
        CreateMap<RecommendationLanguage, RecommendationLanguageUpdateDto>().ReverseMap();
    }
}