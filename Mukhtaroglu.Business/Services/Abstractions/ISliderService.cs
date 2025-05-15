using Mukhtaroglu.Business.Dtos;
using Mukhtaroglu.Business.Services.Abstractions.Generic;

namespace Mukhtaroglu.Business.Services.Abstractions;
public interface ISliderService : IService<SliderGetDto, SliderCreateDto, SliderUpdateDto>
{
}
