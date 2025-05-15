using Mukhtaroglu.DataAccess.Repositories.Implementations.Generic;

namespace Mukhtaroglu.DataAccess.Repositories.Implementations;
internal class SliderRepository : Repository<Slider>, ISliderRepository
{
    public SliderRepository(AppDbContext context) : base(context)
    {
    }
}