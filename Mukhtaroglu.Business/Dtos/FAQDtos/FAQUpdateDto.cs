using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;

public class FAQUpdateDto : IDto
{
    public int Id { get; set; }
    public int Order { get; set; }
    public bool IsActive { get; set; }
    public List<FAQLanguageUpdateDto> FAQLanguages { get; set; } = [];
}


