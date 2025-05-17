using AutoMapper;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Mukhtaroglu.Business.Services.Implementations;
internal class SliderService : ISliderService
{
    private readonly ISliderRepository _repository;
    private readonly ILanguageService _languageService;
    private readonly Languages _selectedLanguage;
    private readonly IMapper _mapper;
    private readonly ICloudinaryService _cloudinaryService;
    public SliderService(ISliderRepository repository, ILanguageService languageService, IMapper mapper, ICloudinaryService cloudinaryService)
    {
        _repository = repository;
        _languageService = languageService;
        _selectedLanguage = _languageService.SelectedLanguage;
        _mapper = mapper;
        _cloudinaryService = cloudinaryService;
    }

    public async Task<bool> CreateAsync(SliderCreateDto dto, ModelStateDictionary ModelState)
    {
        if (!ModelState.IsValid)
            return false;

        if (!dto.Image.CheckSize(2))
        {
            ModelState.AddModelError("Image", "Image size must be less than 2 MB");
            return false;
        }
        if (!dto.Image.CheckType("image"))
        {
            ModelState.AddModelError("Image", "Image type must be image");
            return false;
        }

        if (!LanguageHelper.CheckLanguageItems(dto.SliderLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }

        var entity = _mapper.Map<Slider>(dto);

        string imagePath = await _cloudinaryService.FileCreateAsync(dto.Image);
        entity.ImagePath = imagePath;

        await _repository.CreateAsync(entity);
        await _repository.SaveChangesAsync();

        return true;
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _repository.GetAsync(id);

        if (entity is null)
            throw new NotFoundException("This slider is not found!");

        _repository.Delete(entity);
        await _repository.SaveChangesAsync();
        await _cloudinaryService.FileDeleteAsync(entity.ImagePath);
    }

    public async Task<List<SliderGetDto>> GetAllAsync()
    {
        var entities = await _repository.GetAll(_getIncludeFunc()).ToListAsync();
        var dtos = _mapper.Map<List<SliderGetDto>>(entities);

        return dtos;
    }


    public async Task<SliderGetDto> GetAsync(int id)
    {
        var entity = await _repository.GetAsync(id, _getIncludeFunc());

        if (entity is null)
            throw new NotFoundException("This slider is not found!");

        var dto = _mapper.Map<SliderGetDto>(entity);

        return dto;
    }

    public async Task<SliderUpdateDto> GetUpdatedDtoAsync(int id)
    {
        var entity = await _repository.GetAsync(id, x => x.Include(x => x.SliderLanguages));

        if (entity is null)
            throw new NotFoundException("This slider is not found!");

        var dto = _mapper.Map<SliderUpdateDto>(entity);

        return dto;
    }

    public async Task<bool> UpdateAsync(SliderUpdateDto dto, ModelStateDictionary ModelState)
    {
        if (!ModelState.IsValid)
            return false;

        if (dto.Image is { })
        {
            if (dto.Image.CheckSize(2))
            {
                ModelState.AddModelError("Image", "Image size must be less than 2 MB");
                return false;
            }
            if (!dto.Image.CheckType("image"))
            {
                ModelState.AddModelError("Image", "Image type must be image");
                return false;
            }
        }


        if (!LanguageHelper.CheckLanguageItems(dto.SliderLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }

        var existEntity = await _repository.GetAsync(dto.Id, x => x.Include(x => x.SliderLanguages));

        if (existEntity is null)
            throw new NotFoundException("This slider is not found!");

        existEntity = _mapper.Map(dto, existEntity);

        if (dto.Image is { })
        {
            string imagePath = await _cloudinaryService.FileCreateAsync(dto.Image);
            await _cloudinaryService.FileDeleteAsync(existEntity.ImagePath);
            existEntity.ImagePath = imagePath;
        }

        _repository.Update(existEntity);
        await _repository.SaveChangesAsync();

        return true;
    }

    private Func<IQueryable<Slider>, IIncludableQueryable<Slider, object>> _getIncludeFunc()
                                                         => x => x.Include(x => x.SliderLanguages.Where(x => x.LanguageId == (int)_selectedLanguage));
}
