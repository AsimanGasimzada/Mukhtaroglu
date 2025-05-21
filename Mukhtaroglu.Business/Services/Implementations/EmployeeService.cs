using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Mukhtaroglu.Business.Services.Implementations;
internal class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repository;
    private readonly ILanguageService _languageService;
    private readonly Languages _selectedLanguage;
    private readonly IMapper _mapper;
    private readonly ICloudinaryService _cloudinaryService;

    public EmployeeService(ILanguageService languageService, IMapper mapper, ICloudinaryService cloudinaryService, IEmployeeRepository repository)
    {
        _languageService = languageService;
        _selectedLanguage = _languageService.SelectedLanguage;
        _mapper = mapper;
        _cloudinaryService = cloudinaryService;
        _repository = repository;
    }

    public async Task<bool> CreateAsync(EmployeeCreateDto dto, ModelStateDictionary ModelState)
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

        if (!LanguageHelper.CheckLanguageItems(dto.EmployeeLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }

        var entity = _mapper.Map<Employee>(dto);
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
            throw new NotFoundException("Employee not found");

        _repository.Delete(entity);
        await _repository.SaveChangesAsync();
        await _cloudinaryService.FileDeleteAsync(entity.ImagePath);
    }

    public async Task<List<EmployeeGetDto>> GetAllAsync()
    {
        var entities = await _repository.GetAll(_getIncludeFunc()).ToListAsync();

        var dtos = _mapper.Map<List<EmployeeGetDto>>(entities);

        return dtos;
    }


    public async Task<EmployeeGetDto> GetAsync(int id)
    {
        var entity = await _repository.GetAsync(id, _getIncludeFunc());

        if (entity is null)
            throw new NotFoundException("Employee not found");

        var dto = _mapper.Map<EmployeeGetDto>(entity);

        return dto;
    }

    public async Task<EmployeeUpdateDto> GetUpdatedDtoAsync(int id)
    {
        var entity = await _repository.GetAsync(id, x => x.Include(x => x.EmployeeLanguages));

        if (entity is null)
            throw new NotFoundException("Employee not found");

        var dto = _mapper.Map<EmployeeUpdateDto>(entity);

        return dto;
    }

    public async Task<bool> UpdateAsync(EmployeeUpdateDto dto, ModelStateDictionary ModelState)
    {
        if (!ModelState.IsValid)
            return false;

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

        if (!LanguageHelper.CheckLanguageItems(dto.EmployeeLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("", "Somethings is wrong");
            return false;
        }

        var existEntity = await _repository.GetAsync(dto.Id, x => x.Include(x => x.EmployeeLanguages));

        if (existEntity is null)
            throw new NotFoundException("Employee not found");

        existEntity = _mapper.Map(dto, existEntity);

        if (dto.Image is { })
        {
            string imagePath = await _cloudinaryService.FileCreateAsync(dto.Image);
            dto.ImagePath = imagePath;
            await _cloudinaryService.FileDeleteAsync(existEntity.ImagePath);
        }

        _repository.Update(existEntity);
        await _repository.SaveChangesAsync();

        return true;
    }
    private Func<IQueryable<Employee>, IIncludableQueryable<Employee, object>> _getIncludeFunc()
                                           => x => x.Include(x => x.EmployeeLanguages.Where(x => x.LanguageId == (int)_selectedLanguage));
}
