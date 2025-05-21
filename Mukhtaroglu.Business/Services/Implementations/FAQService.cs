using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Mukhtaroglu.Business.Services.Implementations;
internal class FAQService : IFAQService
{
    private readonly IFAQRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILanguageService _languageService;
    private readonly Languages _selectedLanguage;

    public FAQService(IFAQRepository repository, IMapper mapper, ILanguageService languageService)
    {
        _repository = repository;
        _mapper = mapper;
        _languageService = languageService;
        _selectedLanguage = _languageService.SelectedLanguage;
    }

    public async Task<bool> CreateAsync(FAQCreateDto dto, ModelStateDictionary ModelState)
    {
        if (!ModelState.IsValid)
            return false;

        if (!LanguageHelper.CheckLanguageItems(dto.FAQLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }

        var entity = _mapper.Map<FAQ>(dto);

        await _repository.CreateAsync(entity);
        await _repository.SaveChangesAsync();

        return true;
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _repository.GetAsync(id);

        if (entity is null)
            throw new NotFoundException("FAQ not found");

        _repository.Delete(entity);
        await _repository.SaveChangesAsync();
    }

    public async Task<List<FAQGetDto>> GetAllAsync()
    {
        var query = _repository.GetAll(_getIncludeFunc());

        var entities = await _repository.OrderBy(query, x => x.Order).ToListAsync();

        var dtos = _mapper.Map<List<FAQGetDto>>(entities);

        return dtos;
    }


    public async Task<FAQGetDto> GetAsync(int id)
    {
        var entity = await _repository.GetAsync(id, _getIncludeFunc());

        if (entity is null)
            throw new NotFoundException("FAQ not found");

        var dto = _mapper.Map<FAQGetDto>(entity);

        return dto;
    }

    public async Task<FAQUpdateDto> GetUpdatedDtoAsync(int id)
    {
        var entity = await _repository.GetAsync(id, x => x.Include(x => x.FAQLanguages));

        if (entity is null)
            throw new NotFoundException("FAQ not found");

        var dto = _mapper.Map<FAQUpdateDto>(entity);

        return dto;
    }

    public async Task<bool> UpdateAsync(FAQUpdateDto dto, ModelStateDictionary ModelState)
    {
        if (!ModelState.IsValid)
            return false;

        if (!LanguageHelper.CheckLanguageItems(dto.FAQLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }

        var existEntity = await _repository.GetAsync(dto.Id, x => x.Include(x => x.FAQLanguages));

        if (existEntity is null)
            throw new NotFoundException("FAQ not found");

        existEntity = _mapper.Map(dto, existEntity);

        _repository.Update(existEntity);
        await _repository.SaveChangesAsync();

        return true;
    }
    private Func<IQueryable<FAQ>, IIncludableQueryable<FAQ, object>> _getIncludeFunc()
                                => x => x.Include(x => x.FAQLanguages.Where(x => x.LanguageId == (int)_selectedLanguage));
}
