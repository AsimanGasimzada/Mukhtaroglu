using Microsoft.AspNetCore.Mvc;
using Mukhtaroglu.Business.Dtos;
using Mukhtaroglu.Business.Services.Abstractions;
using System.Threading.Tasks;

namespace Mukhtaroglu.Presentation.Areas.Admin.Controllers;
[Area("Admin")]
public class SettingController : Controller
{
    private readonly ISettingService _service;

    public SettingController(ISettingService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View(result);
    }

    public async Task<IActionResult> Update(int id)
    {
        var result=await _service.GetUpdatedDtoAsync(id);

        return View(result);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Update(SettingUpdateDto dto)
    {
        var result = await _service.UpdateAsync(dto, ModelState);
        
        if (!result)
            return View(dto);

        TempData["Success"] = "Setting updated successfully.";
        return RedirectToAction(nameof(Index));
    }
}
