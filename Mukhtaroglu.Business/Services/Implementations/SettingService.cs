using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Mukhtaroglu.Business.Services.Implementations;
internal class SettingService : ISettingService
{
    private readonly ISettingRepository _settingRepository;
    private readonly ILanguageService _languageService;
    private readonly Languages _selectedLanguage;
    private readonly IMapper _mapper;

    public SettingService(ISettingRepository settingRepository, ILanguageService languageService, IMapper mapper)
    {
        _settingRepository = settingRepository;
        _languageService = languageService;
        _selectedLanguage = _languageService.SelectedLanguage;
        _mapper = mapper;
    }
    public async Task<bool> CreateAsync(SettingCreateDto dto, ModelStateDictionary ModelState)
    {
        if (!ModelState.IsValid)
            return false;

        var isExistKey = await _settingRepository.IsExistAsync(x => x.Key == dto.Key);

        if (isExistKey)
        {
            ModelState.AddModelError("Key", "This key already exists");
            return false;
        }

        if (!LanguageHelper.CheckLanguageItems(dto.SettingLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }

        var entity = _mapper.Map<Setting>(dto);
        await _settingRepository.CreateAsync(entity);
        await _settingRepository.SaveChangesAsync();

        return true;
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _settingRepository.GetAsync(id);

        if (entity is null)
            throw new NotFoundException("Setting not found");

        _settingRepository.Delete(entity);
        await _settingRepository.SaveChangesAsync();
    }

    public async Task<List<SettingGetDto>> GetAllAsync()
    {
        var entities = await _settingRepository.GetAll(_getIncludeFunc()).ToListAsync();

        var dtos = _mapper.Map<List<SettingGetDto>>(entities);

        return dtos;
    }

    public async Task<SettingGetDto> GetAsync(int id)
    {
        var entity = await _settingRepository.GetAsync(id, _getIncludeFunc());

        if (entity is null)
            throw new NotFoundException("Setting not found");

        var dto = _mapper.Map<SettingGetDto>(entity);

        return dto;
    }

    public async Task<SettingUpdateDto> GetUpdatedDtoAsync(int id)
    {
        var entity = await _settingRepository.GetAsync(id, x => x.Include(x => x.SettingLanguages));

        if (entity is null)
            throw new NotFoundException("Setting not found");

        var dto = _mapper.Map<SettingUpdateDto>(entity);

        return dto;
    }

    public async Task<bool> UpdateAsync(SettingUpdateDto dto, ModelStateDictionary ModelState)
    {
        if (!ModelState.IsValid)
            return false;

        var entity = await _settingRepository.GetAsync(dto.Id, x => x.Include(x => x.SettingLanguages));

        if (entity is null)
            throw new NotFoundException("Setting not found");

        if (!LanguageHelper.CheckLanguageItems(dto.SettingLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }

        entity = _mapper.Map(dto, entity);

        _settingRepository.Update(entity);
        await _settingRepository.SaveChangesAsync();

        return true;
    }

    private Func<IQueryable<Setting>, IIncludableQueryable<Setting, object>> _getIncludeFunc()
                        => x => x.Include(x => x.SettingLanguages.Where(x => x.LanguageId == (int)_selectedLanguage));
}
