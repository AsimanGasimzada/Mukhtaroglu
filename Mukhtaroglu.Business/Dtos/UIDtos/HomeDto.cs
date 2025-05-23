using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;
public class HomeDto : IDto
{
    public List<SliderGetDto> Sliders { get; set; } = [];
}
