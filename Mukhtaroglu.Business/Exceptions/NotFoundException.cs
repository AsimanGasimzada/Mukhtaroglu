using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Exceptions;
internal class NotFoundException(string message = "Element is not found!", int statusCode = 404) : Exception(message), IBaseException
{
    public int StatusCode { get; set; } = statusCode;
}
