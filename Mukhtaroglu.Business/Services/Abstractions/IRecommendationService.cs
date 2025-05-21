using Mukhtaroglu.Business.Services.Abstractions.Generic;

namespace Mukhtaroglu.Business.Services.Abstractions;
public interface IRecommendationService : IService<RecommendationGetDto, RecommendationCreateDto, RecommendationUpdateDto> { }