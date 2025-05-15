using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Mukhtaroglu.Business.Services.Abstractions;
using Mukhtaroglu.Core.Enums;

namespace Mukhtaroglu.Business.Services.Implementations;

internal class LanguageService : ILanguageService
{
    private readonly IHttpContextAccessor _contextAccessor;
    private const string COOKIE_KEY = "SelectedLanguage";
    public Languages SelectedLanguage
    {
        get
        {
            return _getEnumValue(GetSelectedCulture());
        }
        set
        {
            string culture = value switch
            {
                Languages.Azerbaijani => "az",
                Languages.English => "en",
                Languages.Russian => "ru",
                _ => "az"
            };
            SelectCulture(culture);
        }
    }

    public LanguageService(IHttpContextAccessor contextAccessor)
    {
        _contextAccessor = contextAccessor;
    }

   

    public void SelectCulture(string culture)
    {
        if (culture != "az" && culture != "en" && culture != "ru")
            culture = "az";

        Languages selectedLanguage = _getEnumValue(culture);

        if (!string.IsNullOrEmpty(culture))
        {
            _contextAccessor.HttpContext?.Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTime.UtcNow.AddYears(1) }
                );

            _contextAccessor.HttpContext?.Response.Cookies.Append(COOKIE_KEY, culture);
        }
    }

    private static Languages _getEnumValue(string culture)
    {
        Languages selectedLanguage = Languages.Azerbaijani;

        if (culture == "en")
            selectedLanguage = Languages.English;
        else if (culture == "ru")
            selectedLanguage = Languages.Russian;

        return selectedLanguage;
    }

    public string GetSelectedCulture()
    {
        string? culture = _contextAccessor.HttpContext?.Request.Cookies[COOKIE_KEY];

        if (string.IsNullOrWhiteSpace(culture))
        {
            culture = "az";
            SelectCulture(culture);
        }

        return culture;
    }
}