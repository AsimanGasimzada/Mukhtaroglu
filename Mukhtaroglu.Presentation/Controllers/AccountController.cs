using Microsoft.AspNetCore.Mvc;
using Mukhtaroglu.Business.Dtos;
using Mukhtaroglu.Business.Services.Abstractions;
using System.Threading.Tasks;

namespace Mukhtaroglu.Presentation.Controllers;
public class AccountController : Controller
{
    private readonly IAuthService _service;

    public AccountController(IAuthService service)
    {
        _service = service;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginDto dto)
    {
        var result = await _service.LoginAsync(dto, ModelState);

        if (!result)
        {
            return View(dto);
        }

        return RedirectToAction("Index", "Home");
    }

    public async Task<IActionResult> Logout()
    {
        await _service.LogoutAsync();

        return RedirectToAction("Index", "Home");
    }
}
