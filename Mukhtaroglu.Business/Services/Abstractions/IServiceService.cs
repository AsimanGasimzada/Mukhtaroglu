using Mukhtaroglu.Business.Services.Abstractions.Generic;

namespace Mukhtaroglu.Business.Services.Abstractions;
public interface IServiceService : IService<ServiceGetDto, ServiceCreateDto, ServiceUpdateDto>
{
}
