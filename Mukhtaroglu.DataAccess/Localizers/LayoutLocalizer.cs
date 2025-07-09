using Microsoft.Extensions.Localization;

namespace Mukhtaroglu.DataAccess.Localizers;
public class LayoutLocalizer
{
    private readonly IStringLocalizer _localizer;

    public LayoutLocalizer(IStringLocalizerFactory factory)
    {
        _localizer = factory.Create("Layout", "Mukhtaroglu.Presentation");
    }

    public string GetValue(string key)
    {
        return _localizer.GetString(key);
    }
}