using Microsoft.AspNetCore.Mvc;
using Mukhtaroglu.Business.Services.Abstractions;
using System.Threading.Tasks;

namespace Mukhtaroglu.Presentation.Controllers;
public class TeamController : Controller
{
    private readonly IEmployeeService _service;

    public TeamController(IEmployeeService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index(int id)
    {
        var employee = await _service.GetAsync(id);
       
        return View(employee);
    }
}
