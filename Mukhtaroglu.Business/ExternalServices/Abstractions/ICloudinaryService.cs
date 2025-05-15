using Microsoft.AspNetCore.Http;

namespace Mukhtaroglu.Business.ExternalServices.Abstractions;
internal interface ICloudinaryService
{
    Task<string> FileCreateAsync(IFormFile file);
    Task<bool> FileDeleteAsync(string filePath);
}