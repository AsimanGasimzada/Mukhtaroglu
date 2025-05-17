using Mukhtaroglu.DataAccess.Repositories.Implementations.Generic;

namespace Mukhtaroglu.DataAccess.Repositories.Implementations;
internal class SettingRepository(AppDbContext context) : Repository<Setting>(context), ISettingRepository { }