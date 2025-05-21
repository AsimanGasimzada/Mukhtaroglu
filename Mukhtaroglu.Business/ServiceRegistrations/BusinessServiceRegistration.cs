using Microsoft.Extensions.DependencyInjection;
using Mukhtaroglu.Business.ExternalServices.Implementations;
using Mukhtaroglu.Business.Services.Implementations;

namespace Mukhtaroglu.Business.ServiceRegistrations;
public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(BusinessServiceRegistration).Assembly);
        services.AddHttpContextAccessor();

        _addServices(services);
        _addExternalServices(services);
        return services;
    }

    private static void _addExternalServices(IServiceCollection services)
    {
        services.AddSingleton<ICloudinaryService, CloudinaryService>();
    }
    private static void _addServices(IServiceCollection services)
    {
        services.AddScoped<ILanguageService, LanguageService>();
        services.AddScoped<ISliderService, SliderService>();
        services.AddScoped<IRecommendationService, RecommendationService>();
        services.AddScoped<IServiceService, ServiceService>();
        services.AddScoped<ISettingService, SettingService>();
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IFAQService, FAQService>();
    }
}
