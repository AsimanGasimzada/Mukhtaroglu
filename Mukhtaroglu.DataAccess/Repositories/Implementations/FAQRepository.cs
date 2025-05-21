using Mukhtaroglu.DataAccess.Repositories.Implementations.Generic;

namespace Mukhtaroglu.DataAccess.Repositories.Implementations;
internal class FAQRepository(AppDbContext context) : Repository<FAQ>(context), IFAQRepository { }
