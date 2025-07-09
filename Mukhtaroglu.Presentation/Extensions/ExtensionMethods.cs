using Microsoft.AspNetCore.Localization;
using Mukhtaroglu.DataAccess.DataInitalizers;

namespace Mukhtaroglu.Presentation.Extensions;

public static class ExtensionMethods
{
    public static void ConfigureLocalizerOptions(this IApplicationBuilder app)
    {
        var supportedCultures = new[] { "az", "en", "ru" };

        var localizationOptions = new RequestLocalizationOptions()
            .SetDefaultCulture("az")
            .AddSupportedCultures(supportedCultures)
            .AddSupportedUICultures(supportedCultures);

        localizationOptions.RequestCultureProviders = new List<IRequestCultureProvider>
        {
              new CookieRequestCultureProvider(),
              new AcceptLanguageHeaderRequestCultureProvider()
        };

        app.UseRequestLocalization(localizationOptions);
    }


    public static string GetReturnUrl(this HttpRequest Request)
    {
        string? returnUrl = Request.Headers["Referer"];

        if (string.IsNullOrEmpty(returnUrl))
            returnUrl = "/";

        return returnUrl;
    }

    public static async Task InitDatabaseAsync(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var initializer = scope.ServiceProvider.GetRequiredService<DbContextInitalizer>();
            await initializer.InitDatabaseAsync();
        }
    }
}
