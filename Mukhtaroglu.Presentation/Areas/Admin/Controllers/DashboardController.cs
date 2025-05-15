using Microsoft.AspNetCore.Mvc;

namespace Mukhtaroglu.Presentation.Areas.Admin.Controllers;
[Area("Admin")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
