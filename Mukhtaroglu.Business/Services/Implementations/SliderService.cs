using Microsoft.AspNetCore.Mvc.ModelBinding;
using Mukhtaroglu.Business.Dtos;
using Mukhtaroglu.Business.Services.Abstractions;

namespace Mukhtaroglu.Business.Services.Implementations;
internal class SliderService : ISliderService
{
    public Task<bool> CreateAsync(SliderCreateDto dto, ModelStateDictionary ModelState)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<SliderGetDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SliderGetDto> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<SliderUpdateDto> GetUpdatedDtoAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(SliderUpdateDto dto, ModelStateDictionary ModelState)
    {
        throw new NotImplementedException();
    }
}
