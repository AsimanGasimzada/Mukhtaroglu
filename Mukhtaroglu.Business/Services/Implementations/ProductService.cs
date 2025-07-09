using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Runtime.InteropServices;

namespace Mukhtaroglu.Business.Services.Implementations;
internal class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper;
    private readonly ICloudinaryService _cloudinaryService;
    private readonly ILanguageService _languageService;
    private readonly Languages _selectedLanguage;

    public ProductService(IProductRepository repository, IMapper mapper, ICloudinaryService cloudinaryService, ILanguageService languageService)
    {
        _repository = repository;
        _mapper = mapper;
        _cloudinaryService = cloudinaryService;
        _languageService = languageService;
        _selectedLanguage = _languageService.SelectedLanguage;
    }

    public async Task<bool> CreateAsync(ProductCreateDto dto, ModelStateDictionary ModelState)
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

        if (!LanguageHelper.CheckLanguageItems(dto.ProductLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("ProductLanguages", "Language items are not valid.");
            return false;
        }

        string imagePath = await _cloudinaryService.FileCreateAsync(dto.Image);

        var product = _mapper.Map<Product>(dto);

        product.ImagePath = imagePath;

        await _repository.CreateAsync(product);
        await _repository.SaveChangesAsync();

        return true;
    }

    public async Task DeleteAsync(int id)
    {
        var product = await _repository.GetAsync(id);

        if (product == null)
            throw new NotFoundException("Product not found");

        _repository.Delete(product);
        await _repository.SaveChangesAsync();
        await _cloudinaryService.FileDeleteAsync(product.ImagePath);
    }

    public async Task<List<ProductGetDto>> GetAllAsync()
    {
        var products = await _repository.GetAll(_getIncludeFunc()).ToListAsync();

        var dtos = _mapper.Map<List<ProductGetDto>>(products);

        return dtos;
    }


    public async Task<ProductGetDto> GetAsync(int id)
    {
        var product=await _repository.GetAsync(id, _getIncludeFunc());

        if (product == null)
            throw new NotFoundException("Product not found");

        var dto = _mapper.Map<ProductGetDto>(product);

        return dto;
    }

    public async Task<ProductUpdateDto> GetUpdatedDtoAsync(int id)
    {
        var product =await _repository.GetAsync(id, x=>x.Include(x=>x.ProductLanguages));

        if (product == null)
            throw new NotFoundException("Product not found");

        var dto = _mapper.Map<ProductUpdateDto>(product);
        return dto;
    }

    public async Task<bool> UpdateAsync(ProductUpdateDto dto, ModelStateDictionary ModelState)
    {
        if(!ModelState.IsValid)
            return false;

        var existProduct= await _repository.GetAsync(dto.Id,x=>x.Include(x=>x.ProductLanguages));

        if (existProduct == null)
            throw new NotFoundException("Product not found");

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

        if (!LanguageHelper.CheckLanguageItems(dto.ProductLanguages.Select(x => x.LanguageId)))
        {
            ModelState.AddModelError("ProductLanguages", "Language items are not valid.");
            return false;
        }

        existProduct = _mapper.Map(dto, existProduct);

        if (dto.Image != null)
        {
            var oldImagePath = existProduct.ImagePath;
            existProduct.ImagePath = await _cloudinaryService.FileCreateAsync(dto.Image);
            await _cloudinaryService.FileDeleteAsync(oldImagePath);
        }

        _repository.Update(existProduct);
        await _repository.SaveChangesAsync();

        return true;
    }
    private Func<IQueryable<Product>, IIncludableQueryable<Product, object>> _getIncludeFunc()
                            => x => x.Include(x => x.ProductLanguages.Where(x => x.LanguageId == (int)_selectedLanguage));
}
