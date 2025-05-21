using Mukhtaroglu.DataAccess.Repositories.Implementations.Generic;

namespace Mukhtaroglu.DataAccess.Repositories.Implementations;
internal class EmployeeRepository(AppDbContext context) : Repository<Employee>(context), IEmployeeRepository { }
