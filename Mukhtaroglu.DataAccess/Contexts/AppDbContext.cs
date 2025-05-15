using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mukhtaroglu.Core.Entities;
using Mukhtaroglu.DataAccess.Interceptors;

namespace Mukhtaroglu.DataAccess.Contexts;
internal class AppDbContext : IdentityDbContext<IdentityUser>
{
    internal bool BypassAuditableInterceptor { get; set; } = false;
    private readonly AuditableInterceptor _auditableInterceptor;
    public AppDbContext(DbContextOptions options, AuditableInterceptor auditableInterceptor) : base(options)
    {
        _auditableInterceptor = auditableInterceptor;
    }

    public required DbSet<Language> Languages { get; set; }
    public required DbSet<Slider> Sliders { get; set; }
    public required DbSet<SliderLanguage> SliderLanguages { get; set; }
    public required DbSet<Service> Services { get; set; }
    public required DbSet<ServiceLanguage> ServiceLanguages { get; set; }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(builder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_auditableInterceptor);
        base.OnConfiguring(optionsBuilder);
    }
}
