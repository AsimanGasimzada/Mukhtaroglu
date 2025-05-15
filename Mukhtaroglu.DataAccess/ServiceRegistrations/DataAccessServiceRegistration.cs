using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mukhtaroglu.Core.Entities;
using Mukhtaroglu.DataAccess.Contexts;
using Mukhtaroglu.DataAccess.Interceptors;

namespace Mukhtaroglu.DataAccess.ServiceRegistrations;
public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer("Server=.;Database=MukhtarogluDB;Trusted_Connection=True;TrustServerCertificate=True;");
        });


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

        services.AddScoped<AuditableInterceptor>();

        return services;
    }
}
