using Microsoft.Extensions.Localization;

namespace Mukhtaroglu.DataAccess.Localizers;

public class ContactLocalizer
{
    private readonly IStringLocalizer _localizer;

    public ContactLocalizer(IStringLocalizerFactory factory)
    {
        _localizer = factory.Create("Contact", "Mukhtaroglu.Presentation");
    }

    public string GetValue(string key)
    {
        return _localizer.GetString(key);
    }
}