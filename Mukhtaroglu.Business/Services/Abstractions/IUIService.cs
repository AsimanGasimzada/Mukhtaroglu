using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Mukhtaroglu.Business.Services.Abstractions;
public interface IUIService
{
    Task<HomeDto> GetHomeDtoAsync();
    Task<FAQDto> GetFAQDtoAsync();
    Task<AboutDto> GetAboutDtoAsync();
    Task<ContactDto> GetContactDtoAsync();
    Task<Dictionary<string, string>> GetSettingsAsync();
    Task<bool> SendContactMailAsync(ContactSendMailDto dto, ModelStateDictionary ModelState);
}
