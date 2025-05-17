using Mukhtaroglu.DataAccess.Repositories.Implementations.Generic;

namespace Mukhtaroglu.DataAccess.Repositories.Implementations;

internal class ServiceRepository(AppDbContext context) : Repository<Service>(context), IServiceRepository { }