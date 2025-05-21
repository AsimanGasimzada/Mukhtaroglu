using Mukhtaroglu.Business.Services.Abstractions.Generic;

namespace Mukhtaroglu.Business.Services.Abstractions;
public interface IEmployeeService : IService<EmployeeGetDto, EmployeeCreateDto, EmployeeUpdateDto> { }

