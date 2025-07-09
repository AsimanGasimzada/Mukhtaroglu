using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mukhtaroglu.DataAccess.DataInitalizers;
using Mukhtaroglu.DataAccess.Interceptors;
using Mukhtaroglu.DataAccess.Localizers;
using Mukhtaroglu.DataAccess.Repositories.Implementations;

namespace Mukhtaroglu.DataAccess.ServiceRegistrations;
public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {
        _addDatabase(services, configuration);
        _addIdentity(services);
        _addRepositories(services);
        _addLocalizers(services);

        services.AddScoped<AuditableInterceptor>();
        services.AddScoped<DbContextInitalizer>();

        return services;
    }

    private static void _addRepositories(IServiceCollection services)
    {
        services.AddScoped<IServiceRepository, ServiceRepository>();
        services.AddScoped<ISliderRepository, SliderRepository>();
        services.AddScoped<ISettingRepository, SettingRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IFAQRepository, FAQRepository>();
        services.AddScoped<IRecommendationRepository, RecommendationRepository>();
        services.AddScoped<IAboutRepository, AboutRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
    }

    private static void _addDatabase(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("Default"));
        });
    }

    private static void _addIdentity(IServiceCollection services)
    {
        services.AddIdentity<AppUser, IdentityRole>(options =>
        {
            options.User.RequireUniqueEmail = true;

            options.Password.RequireDigit = true;
            options.Password.RequiredLength = 8;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireNonAlphanumeric = false;

            options.SignIn.RequireConfirmedEmail = true;

            options.Lockout.AllowedForNewUsers = false;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            options.Lockout.MaxFailedAccessAttempts = 5;

        }).AddDefaultTokenProviders()
          .AddEntityFrameworkStores<AppDbContext>();
    }

    private static void _addLocalizers(IServiceCollection services)
    {
        services.AddSingleton<AuthLocalizer>();
        services.AddSingleton<HomeLocalizer>();
        services.AddSingleton<ContactLocalizer>();
        services.AddSingleton<LayoutLocalizer>();
    }
}
