using Microsoft.AspNetCore.Mvc;
using Mukhtaroglu.Business.Services.Abstractions;
using System.Threading.Tasks;

namespace Mukhtaroglu.Presentation.Controllers;
public class FAQController : Controller
{
    private readonly IUIService _uiService;

    public FAQController(IUIService uiService)
    {
        _uiService = uiService;
    }

    public async Task<IActionResult> Index()
    {
        var result = await _uiService.GetFAQDtoAsync();

        return View(result);
    }
}
