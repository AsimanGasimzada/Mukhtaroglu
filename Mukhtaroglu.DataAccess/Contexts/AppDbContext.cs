using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mukhtaroglu.Core.Entities;
using Mukhtaroglu.DataAccess.DataInitalizers;
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
    public required DbSet<Setting> Settings { get; set; }
    public required DbSet<SettingLanguage> SettingLanguages { get; set; }
    public required DbSet<Employee> Employees { get; set; }
    public required DbSet<EmployeeLanguage> EmployeeLanguages { get; set; }
    public required DbSet<FAQ> FAQs { get; set; }
    public required DbSet<FAQLanguage> FAQLanguages { get; set; }
    public required DbSet<Recommendation> Recommendations { get; set; }
    public required DbSet<RecommendationLanguage> RecommendationLanguages { get; set; }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        builder.AddSeedData();

        builder.Entity<Slider>().HasQueryFilter(x => !x.IsDeleted);
        base.OnModelCreating(builder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_auditableInterceptor);
        base.OnConfiguring(optionsBuilder);
    }
}
