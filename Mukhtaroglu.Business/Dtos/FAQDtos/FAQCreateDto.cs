using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;
public class FAQCreateDto : IDto
{
    public int Order { get; set; }
    public List<FAQLanguageCreateDto> FAQLanguages { get; set; } = [];
}