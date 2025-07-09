using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Mukhtaroglu.Business.Services.Abstractions;
public interface IAuthService
{
    Task<bool> LoginAsync(LoginDto dto, ModelStateDictionary ModelState);
    Task<bool> LogoutAsync();
}
