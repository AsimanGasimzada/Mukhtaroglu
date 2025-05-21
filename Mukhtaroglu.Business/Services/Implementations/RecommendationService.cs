using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Mukhtaroglu.Business.Services.Implementations;
internal class RecommendationService : IRecommendationService
{
    private readonly IRecommendationRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILanguageService _languageService;
    private readonly Languages _selectedLanguage;

    public RecommendationService(IRecommendationRepository repository, IMapper mapper, ILanguageService languageService)
    {
        _repository = repository;
        _mapper = mapper;
        _languageService = languageService;
        _selectedLanguage = _languageService.SelectedLanguage;
    }

    public async Task<bool> CreateAsync(RecommendationCreateDto dto, ModelStateDictionary ModelState)
    {
        if (!ModelState.IsValid)
            return false;

        if (!LanguageHelper.CheckLanguageItems(dto.RecommendationLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }

        var entity = _mapper.Map<Recommendation>(dto);

        await _repository.CreateAsync(entity);
        await _repository.SaveChangesAsync();

        return true;
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _repository.GetAsync(id);

        if (entity is null)
            throw new NotFoundException("Recommendation not found");

        _repository.Delete(entity);
        await _repository.SaveChangesAsync();
    }

    public async Task<List<RecommendationGetDto>> GetAllAsync()
    {
        var entities = await _repository.GetAll(_getIncludeFunc()).ToListAsync();

        if (entities is null)
            throw new NotFoundException("Recommendations not found");

        var dtos = _mapper.Map<List<RecommendationGetDto>>(entities);
        return dtos;
    }

    private Func<IQueryable<Recommendation>, IIncludableQueryable<Recommendation, object>> _getIncludeFunc()
                                        => x => x.Include(x => x.RecommendationLanguages.Where(x => x.LanguageId == (int)_selectedLanguage));


    public async Task<RecommendationGetDto> GetAsync(int id)
    {
        var entity = await _repository.GetAsync(id);

        if (entity is null)
            throw new NotFoundException("Recommendation not found");

        var dto = _mapper.Map<RecommendationGetDto>(entity);

        return dto;
    }

    public async Task<RecommendationUpdateDto> GetUpdatedDtoAsync(int id)
    {
        var entity = await _repository.GetAsync(id, x => x.Include(x => x.RecommendationLanguages));

        if (entity is null)
            throw new NotFoundException("Recommendation not found");

        var dto = _mapper.Map<RecommendationUpdateDto>(entity);

        return dto;
    }

    public async Task<bool> UpdateAsync(RecommendationUpdateDto dto, ModelStateDictionary ModelState)
    {
        if (!ModelState.IsValid)
            return false;

        if (!LanguageHelper.CheckLanguageItems(dto.RecommendationLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }

        var entity = await _repository.GetAsync(dto.Id, x => x.Include(x => x.RecommendationLanguages));

        if (entity is null)
            throw new NotFoundException("Recommendation not found");

        var updatedEntity = _mapper.Map(dto, entity);

        _repository.Update(updatedEntity);
        await _repository.SaveChangesAsync();

        return true;
    }
}
