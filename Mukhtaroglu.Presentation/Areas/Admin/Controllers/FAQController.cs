using Microsoft.AspNetCore.Mvc;
using Mukhtaroglu.Business.Dtos;
using Mukhtaroglu.Business.Services.Abstractions;

namespace Mukhtaroglu.Presentation.Areas.Admin.Controllers;
[Area("Admin")]
public class FAQController : Controller
{
    private readonly IFAQService _service;

    public FAQController(IFAQService service)
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
    public async Task<IActionResult> Create(FAQCreateDto dto)
    {
        var result = await _service.CreateAsync(dto, ModelState);

        if (!result)
            return View(dto);

        TempData["Success"] = "FAQ created successfully.";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        var dto = await _service.GetUpdatedDtoAsync(id);
        return View(dto);
    }


    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Update(FAQUpdateDto dto)
    {
        var result = await _service.UpdateAsync(dto, ModelState);

        if (!result)
            return View(dto);

        TempData["Success"] = "FAQ updated successfully.";
        return RedirectToAction(nameof(Index));
    }


    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);

        return RedirectToAction(nameof(Index));
    }
}
