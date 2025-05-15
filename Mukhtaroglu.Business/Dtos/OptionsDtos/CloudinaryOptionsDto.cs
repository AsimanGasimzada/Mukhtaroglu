using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos.OptionsDtos;
public class CloudinaryOptionsDto : IDto
{
    public string APIKey { get; set; } = null!;
    public string APISecret { get; set; } = null!;
    public string CloudName { get; set; } = null!;

}

