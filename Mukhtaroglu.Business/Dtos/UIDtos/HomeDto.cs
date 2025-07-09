using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Dtos;
public class HomeDto : IDto
{
    public List<SliderGetDto> Sliders { get; set; } = [];
    public List<ServiceGetDto> Services { get; set; } = [];
    public List<RecommendationGetDto> Recommendations { get; set; } = [];
    public AboutGetDto? About { get; set; }
    public List<EmployeeGetDto> Employees { get; set; } = [];
    public List<ProductGetDto> Products { get; set; } = [];
    public Dictionary<string, string> Settings { get; set; } = [];
}