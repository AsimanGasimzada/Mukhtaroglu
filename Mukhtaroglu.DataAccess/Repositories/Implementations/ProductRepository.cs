using Mukhtaroglu.DataAccess.Repositories.Implementations.Generic;

namespace Mukhtaroglu.DataAccess.Repositories.Implementations;
internal class ProductRepository(AppDbContext context) : Repository<Product>(context), IProductRepository { }
