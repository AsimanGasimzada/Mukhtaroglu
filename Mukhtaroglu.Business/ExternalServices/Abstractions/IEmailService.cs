using Mukhtaroglu.Business.Dtos.EmailDtos;

namespace Mukhtaroglu.Business.ExternalServices.Abstractions;
public interface IEmailService
{
    Task SendEmailAsync(EmailSendDto dto);
}