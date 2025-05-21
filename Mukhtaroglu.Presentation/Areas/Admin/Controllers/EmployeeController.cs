using Microsoft.AspNetCore.Mvc;
using Mukhtaroglu.Business.Dtos;
using Mukhtaroglu.Business.Services.Abstractions;

namespace Mukhtaroglu.Presentation.Areas.Admin.Controllers;
[Area("Admin")]
public class EmployeeController : Controller
{
    private readonly IEmployeeService _service;

    public EmployeeController(IEmployeeService service)
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
    public async Task<IActionResult> Create(EmployeeCreateDto dto)
    {
        var result = await _service.CreateAsync(dto, ModelState);

        if (!result)
            return View(dto);

        TempData["Success"] = "Employee created successfully.";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Update(int id)
    {
        var dto = await _service.GetUpdatedDtoAsync(id);
        return View(dto);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Update(EmployeeUpdateDto dto)
    {
        var result = await _service.UpdateAsync(dto, ModelState);

        if (!result)
            return View(dto);

        TempData["Success"] = "Employee updated successfully.";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);

        TempData["Success"] = "Employee deleted successfully.";
        return RedirectToAction(nameof(Index));
    }

}
