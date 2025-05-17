using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CodeActions;
using Mukhtaroglu.Business.Dtos;
using Mukhtaroglu.Business.Services.Abstractions;

namespace Mukhtaroglu.Presentation.Areas.Admin.Controllers;
[Area("Admin")]
public class ServiceController : Controller
{
    private readonly IServiceService _service;

    public ServiceController(IServiceService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View(result);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(ServiceCreateDto dto)
    {
        var result = await _service.CreateAsync(dto, ModelState);

        if (!result)
            return View(dto);

        TempData["Success"] = "Service created successfully.";
        return RedirectToAction(nameof(Index));
    }


    public async Task<IActionResult> Update(int id)
    {
        var dto = await _service.GetUpdatedDtoAsync(id);
        return View(dto);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Update(ServiceUpdateDto dto)
    {
        var result = await _service.UpdateAsync(dto, ModelState);

        if (!result)
            return View(dto);

        TempData["Success"] = "Service updated successfully.";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);

        TempData["Success"] = "Service deleted successfully.";
        return RedirectToAction("Index");
    }
}
