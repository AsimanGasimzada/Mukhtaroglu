using Microsoft.AspNetCore.Mvc;
using Mukhtaroglu.Business.Services.Abstractions;
using Mukhtaroglu.Presentation.Extensions;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Mukhtaroglu.Presentation.Controllers;
public class HomeController : Controller
{
    private readonly IUIService _uiService;
    private readonly ILanguageService _languageService;
    public HomeController(IUIService uiService, ILanguageService languageService)
    {
        _uiService = uiService;
        _languageService = languageService;
    }

    public async Task<IActionResult> Index()
    {
        var homeDto = await _uiService.GetHomeDtoAsync();

        return View(homeDto);
    }

    public IActionResult ChangeCulture(string lang)
    {
        _languageService.SelectCulture(lang);

        var returnUrl = Request.GetReturnUrl();

        return Redirect(returnUrl);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View();
    }
}
