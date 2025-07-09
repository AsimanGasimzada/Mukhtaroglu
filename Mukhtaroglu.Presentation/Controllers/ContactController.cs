using Microsoft.AspNetCore.Mvc;
using Mukhtaroglu.Business.Dtos;
using Mukhtaroglu.Business.Services.Abstractions;
using Mukhtaroglu.DataAccess.Localizers;
using Mukhtaroglu.Presentation.Extensions;
using System.Threading.Tasks;

namespace Mukhtaroglu.Presentation.Controllers;
public class ContactController : Controller
{
    private readonly IUIService _uiService;
    private readonly ContactLocalizer _localizer;
    public ContactController(IUIService uiService, ContactLocalizer localizer)
    {
        _uiService = uiService;
        _localizer = localizer;
    }
    public async Task<IActionResult> Index()
    {
        var result = await _uiService.GetContactDtoAsync();

        return View(result);
    }

    public async Task<IActionResult> SendRequest(ContactSendMailDto dto)
    {

        var result = await _uiService.SendContactMailAsync(dto, ModelState);

        if (!result)
            return Ok(_localizer.GetValue("FailedProcess"));

        return Ok(_localizer.GetValue("SuccessfullProcess"));

    }
}
