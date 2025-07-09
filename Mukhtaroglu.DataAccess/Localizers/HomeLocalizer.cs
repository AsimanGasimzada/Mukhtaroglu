using Microsoft.Extensions.Localization;

namespace Mukhtaroglu.DataAccess.Localizers;

public class HomeLocalizer
{
    private readonly IStringLocalizer _localizer;

    public HomeLocalizer(IStringLocalizerFactory factory)
    {
        _localizer = factory.Create("Home", "Mukhtaroglu.Presentation");
    }

    public string GetValue(string key)
    {
        return _localizer.GetString(key);
    }
}