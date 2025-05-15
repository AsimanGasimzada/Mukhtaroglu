using Mukhtaroglu.DataAccess.Repositories.Implementations.Generic;

namespace Mukhtaroglu.DataAccess.Repositories.Implementations;

internal class ServiceRepository : Repository<Service>, IServiceRepository
{
    public ServiceRepository(AppDbContext context) : base(context)
    {
    }
}
