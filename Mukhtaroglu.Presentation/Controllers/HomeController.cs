using Microsoft.AspNetCore.Mvc;
using Mukhtaroglu.Business.Services.Abstractions;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Mukhtaroglu.Presentation.Controllers;
public class HomeController : Controller
{
    private readonly IUIService _uiService;

    public HomeController(IUIService uiService)
    {
        _uiService = uiService;
    }

    public async Task<IActionResult> Index()
    {
        var homeDto = await _uiService.GetHomeDtoAsync();

        return View(homeDto);
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
