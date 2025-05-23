
namespace Mukhtaroglu.Business.Services.Implementations;
internal class UIService : IUIService
{
    private readonly ISliderService _sliderService;

    public UIService(ISliderService sliderService)
    {
        _sliderService = sliderService;
    }

    public async Task<HomeDto> GetHomeDtoAsync()
    {
        var sliders = await _sliderService.GetAllAsync();

        var homeDto = new HomeDto
        {
            Sliders = sliders
        };

        return homeDto;
    }
}
