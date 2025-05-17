using Mukhtaroglu.DataAccess.Repositories.Implementations.Generic;

namespace Mukhtaroglu.DataAccess.Repositories.Implementations;
internal class SliderRepository(AppDbContext context) : Repository<Slider>(context), ISliderRepository { }