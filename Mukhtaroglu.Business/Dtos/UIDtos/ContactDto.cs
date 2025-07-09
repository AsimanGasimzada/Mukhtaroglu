using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class ContactDto : IDto
{
    public Dictionary<string, string> Settings { get; set; } = [];
}