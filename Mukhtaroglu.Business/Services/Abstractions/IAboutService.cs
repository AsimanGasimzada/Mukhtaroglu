using Mukhtaroglu.Business.Services.Abstractions.Generic;

namespace Mukhtaroglu.Business.Services.Abstractions;
public interface IAboutService : IService<AboutGetDto, AboutCreateDto, AboutUpdateDto>
{
}
