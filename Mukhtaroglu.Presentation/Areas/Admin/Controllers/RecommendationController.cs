using Microsoft.AspNetCore.Mvc;
using Mukhtaroglu.Business.Dtos;
using Mukhtaroglu.Business.Services.Abstractions;
using System.Threading.Tasks;

namespace Mukhtaroglu.Presentation.Areas.Admin.Controllers;
[Area("Admin")]
public class RecommendationController : Controller
{
    private readonly IRecommendationService _service;

    public RecommendationController(IRecommendationService service)
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

    [HttpPost]
    public async Task<IActionResult> Create(RecommendationCreateDto dto)
    {
        if (!ModelState.IsValid)
            return View(dto);
        var result = await _service.CreateAsync(dto, ModelState);
        if (!result)
            return View(dto);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Update(int id)
    {
        var result = await _service.GetUpdatedDtoAsync(id);
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> Update(RecommendationUpdateDto dto)
    {
        var result = await _service.UpdateAsync(dto, ModelState);

        if (!result)
            return View(dto);

        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);

        return RedirectToAction(nameof(Index));
    }
}
