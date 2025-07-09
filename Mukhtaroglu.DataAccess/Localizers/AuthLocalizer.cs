using Microsoft.Extensions.Localization;

namespace Mukhtaroglu.DataAccess.Localizers;
public class AuthLocalizer
{
    private readonly IStringLocalizer _localizer;

    public AuthLocalizer(IStringLocalizerFactory factory)
    {
        _localizer = factory.Create("Auth", "Mukhtaroglu.Presentation");
    }

    public string GetValue(string key)
    {
        return _localizer.GetString(key);
    }
}
