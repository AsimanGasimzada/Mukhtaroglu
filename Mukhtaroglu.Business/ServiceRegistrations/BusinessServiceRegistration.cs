using Microsoft.Extensions.DependencyInjection;
using Mukhtaroglu.Business.Services.Abstractions;
using Mukhtaroglu.Business.Services.Implementations;

namespace Mukhtaroglu.Business.ServiceRegistrations;
public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(BusinessServiceRegistration).Assembly);
        services.AddScoped<ISliderService, SliderService>();
        return services;
    }
}
