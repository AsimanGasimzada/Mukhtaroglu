using Mukhtaroglu.Business.Services.Abstractions.Generic;

namespace Mukhtaroglu.Business.Services.Abstractions;
public interface IProductService : IService<ProductGetDto, ProductCreateDto, ProductUpdateDto> { }
