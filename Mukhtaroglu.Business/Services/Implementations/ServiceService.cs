using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Mukhtaroglu.Business.Services.Implementations;
internal class ServiceService : IServiceService
{
    private readonly IServiceRepository _repository;
    private readonly IMapper _mapper;
    private readonly ICloudinaryService _cloudinaryService;
    private readonly ILanguageService _languageService;
    private readonly Languages _selectedLanguage;


    public ServiceService(IServiceRepository repository, IMapper mapper, ICloudinaryService cloudinaryService, ILanguageService languageService)
    {
        _repository = repository;
        _mapper = mapper;
        _cloudinaryService = cloudinaryService;
        _languageService = languageService;
        _selectedLanguage = _languageService.SelectedLanguage;
    }

    public async Task<bool> CreateAsync(ServiceCreateDto dto, ModelStateDictionary ModelState)
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

        if (!LanguageHelper.CheckLanguageItems(dto.ServiceLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }


        var entity = _mapper.Map<Service>(dto);

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
            throw new NotFoundException("Service not found");

        await _cloudinaryService.FileDeleteAsync(entity.ImagePath);
        _repository.Delete(entity);
        await _repository.SaveChangesAsync();
    }

    public async Task<List<ServiceGetDto>> GetAllAsync()
    {
        var entities = await _repository.GetAll(_getIncludeFunc()).ToListAsync();

        var dtos = _mapper.Map<List<ServiceGetDto>>(entities);

        return dtos;
    }


    public async Task<ServiceGetDto> GetAsync(int id)
    {
        var entity = await _repository.GetAsync(id, _getIncludeFunc());

        if (entity is null)
            throw new NotFoundException("Service not found");

        var dto = _mapper.Map<ServiceGetDto>(entity);

        return dto;
    }

    public async Task<ServiceUpdateDto> GetUpdatedDtoAsync(int id)
    {
        var entity = await _repository.GetAsync(id, x => x.Include(x => x.ServiceLanguages));

        if (entity is null)
            throw new NotFoundException("Service not found");

        var dto = _mapper.Map<ServiceUpdateDto>(entity);

        return dto;
    }

    public async Task<bool> UpdateAsync(ServiceUpdateDto dto, ModelStateDictionary ModelState)
    {
        if (!ModelState.IsValid)
            return false;


        var existEntity = await _repository.GetAsync(dto.Id, x => x.Include(x => x.ServiceLanguages));

        if (existEntity is null)
            throw new NotFoundException("Service not found");

        if (dto.Image is { })
        {
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
        }

        if (!LanguageHelper.CheckLanguageItems(dto.ServiceLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }

        existEntity = _mapper.Map(dto, existEntity);

        if (dto.Image is { })
        {
            await _cloudinaryService.FileDeleteAsync(existEntity.ImagePath);
            string imagePath = await _cloudinaryService.FileCreateAsync(dto.Image);
            existEntity.ImagePath = imagePath;
        }

        _repository.Update(existEntity);
        await _repository.SaveChangesAsync();

        return true;
    }


    private Func<IQueryable<Service>, IIncludableQueryable<Service, object>> _getIncludeFunc()
                                            => x => x.Include(x => x.ServiceLanguages.Where(x => x.LanguageId == (int)_selectedLanguage));

}
