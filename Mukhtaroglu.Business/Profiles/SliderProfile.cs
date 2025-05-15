using AutoMapper;
using Mukhtaroglu.Business.Dtos;
using Mukhtaroglu.Core.Entities;

namespace Mukhtaroglu.Business.Profiles;
internal class SliderProfile : Profile
{
    public SliderProfile()
    {
        CreateMap<Slider, SliderGetDto>().ReverseMap();
        CreateMap<Slider, SliderUpdateDto>().ReverseMap();
        CreateMap<Slider, SliderCreateDto>().ReverseMap();
    }
}
