using Microsoft.AspNetCore.Mvc;
using Mukhtaroglu.Business.Dtos;
using Mukhtaroglu.Business.Services.Abstractions;
using System.Threading.Tasks;

namespace Mukhtaroglu.Presentation.Areas.Admin.Controllers;
[Area("Admin")]
public class SliderController : Controller
{
    private readonly ISliderService _service;

    public SliderController(ISliderService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        var sliders = await _service.GetAllAsync();

        return View(sliders);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(SliderCreateDto dto)
    {
        var result = await _service.CreateAsync(dto, ModelState);

        if (!result)
            return View(dto);

        TempData["Success"] = "Slider created successfully.";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        var dto = await _service.GetUpdatedDtoAsync(id);

        return View(dto);
    }


    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Update(SliderUpdateDto dto)
    {
        var result = await _service.UpdateAsync(dto, ModelState);

        if (!result)
            return View(dto);

        TempData["Success"] = "Slider updated successfully.";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);

        TempData["Success"] = "Slider deleted successfully.";
        return RedirectToAction(nameof(Index));
    }
}
