using Microsoft.AspNetCore.Mvc;
using Mukhtaroglu.Business.Services.Abstractions;
using System.Threading.Tasks;

namespace Mukhtaroglu.Presentation.Controllers;
public class AboutController : Controller
{
    private readonly IUIService _uiService;

    public AboutController(IUIService uiService)
    {
        _uiService = uiService;
    }

    public async Task<IActionResult> Index()
    {
        var result = await _uiService.GetAboutDtoAsync();
        return View(result);
    }
}
