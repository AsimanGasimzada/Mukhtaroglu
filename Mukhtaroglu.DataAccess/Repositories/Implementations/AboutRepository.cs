using Mukhtaroglu.DataAccess.Repositories.Implementations.Generic;

namespace Mukhtaroglu.DataAccess.Repositories.Implementations;
internal class AboutRepository(AppDbContext _context) : Repository<About>(_context), IAboutRepository { }