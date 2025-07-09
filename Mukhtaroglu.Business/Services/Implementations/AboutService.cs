using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Mukhtaroglu.Business.Services.Implementations;
internal class AboutService : IAboutService
{
    private readonly IAboutRepository _repository;
    private readonly IMapper _mapper;
    private readonly ICloudinaryService _cloudinaryService;
    private readonly ILanguageService _languageService;
    private readonly Languages _selectedLanguage;

    public AboutService(IAboutRepository repository, IMapper mapper, ICloudinaryService cloudinaryService, ILanguageService languageService)
    {
        _repository = repository;
        _mapper = mapper;
        _cloudinaryService = cloudinaryService;
        _languageService = languageService;
        _selectedLanguage = _languageService.SelectedLanguage;
    }

    public async Task<bool> CreateAsync(AboutCreateDto dto, ModelStateDictionary ModelState)
    {
        if (!ModelState.IsValid)
            return false;

        if (!dto.Image.CheckSize(2))
        {
            ModelState.AddModelError("Image", "Image size must be less than 2 MB.");
            return false;
        }

        if (!dto.Image.CheckType("image"))
        {
            ModelState.AddModelError("Image", "Image type must be image.");
            return false;
        }

        if (!LanguageHelper.CheckLanguageItems(dto.AboutLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }

        var about = _mapper.Map<About>(dto);
        about.ImagePath = await _cloudinaryService.FileCreateAsync(dto.Image);

        await _repository.CreateAsync(about);
        await _repository.SaveChangesAsync();

        return true;
    }

    public async Task DeleteAsync(int id)
    {
        var about = await _repository.GetAsync(id);

        if (about == null)
            throw new Exception("About not found");

        await _cloudinaryService.FileDeleteAsync(about.ImagePath);

        _repository.Delete(about);
        await _repository.SaveChangesAsync();

    }

    public async Task<List<AboutGetDto>> GetAllAsync()
    {
        var query = _repository.GetAll(_getIncludeFunc());

        var entities = await _repository.OrderBy(query, x => x.Order).ToListAsync();

        var dtos = _mapper.Map<List<AboutGetDto>>(entities);

        return dtos;
    }


    public async Task<AboutGetDto> GetAsync(int id)
    {
        var about = await _repository.GetAsync(id, _getIncludeFunc());

        if (about == null)
            throw new Exception("About not found");

        var aboutDto = _mapper.Map<AboutGetDto>(about);

        return aboutDto;
    }

    public async Task<AboutUpdateDto> GetUpdatedDtoAsync(int id)
    {
        var about = await _repository.GetAsync(id, x => x.Include(x => x.AboutLanguages));

        if (about == null)
            throw new Exception("About not found");

        var aboutUpdateDto = _mapper.Map<AboutUpdateDto>(about);

        return aboutUpdateDto;
    }

    public async Task<bool> UpdateAsync(AboutUpdateDto dto, ModelStateDictionary ModelState)
    {
        if (!ModelState.IsValid)
            return false;

        var existEntity = await _repository.GetAsync(dto.Id, x => x.Include(x => x.AboutLanguages));

        if (existEntity == null)
            throw new NotFoundException("About not found");

        if (dto.Image != null)
        {
            if (!dto.Image.CheckSize(2))
            {
                ModelState.AddModelError("Image", "Image size must be less than 2 MB.");
                return false;
            }
            if (!dto.Image.CheckType("image"))
            {
                ModelState.AddModelError("Image", "Image type must be image.");
                return false;
            }
        }

        if (!LanguageHelper.CheckLanguageItems(dto.AboutLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }

        existEntity = _mapper.Map(dto, existEntity);
        if (dto.Image != null)
        {
            await _cloudinaryService.FileDeleteAsync(existEntity.ImagePath);
            existEntity.ImagePath = await _cloudinaryService.FileCreateAsync(dto.Image);
        }

        _repository.Update(existEntity);
        await _repository.SaveChangesAsync();

        return true;
    }
    private Func<IQueryable<About>, IIncludableQueryable<About, object>> _getIncludeFunc()
                                         => x => x.Include(x => x.AboutLanguages.Where(x => x.LanguageId == (int)_selectedLanguage));
}
