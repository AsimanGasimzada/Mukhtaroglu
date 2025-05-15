using Microsoft.AspNetCore.Mvc.ModelBinding;
using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Services.Abstractions.Generic;
public interface IService<TGetDto, TCreateDto, TUpdateDto>
    where TGetDto : IDto
    where TCreateDto : IDto
    where TUpdateDto : IDto
{
    Task<TGetDto> GetAsync(int id);
    Task<List<TGetDto>> GetAllAsync();
    Task<bool> CreateAsync(TCreateDto dto, ModelStateDictionary ModelState);
    Task<bool> UpdateAsync(TUpdateDto dto, ModelStateDictionary ModelState);
    Task<TUpdateDto> GetUpdatedDtoAsync(int id);
    Task DeleteAsync(int id);
}