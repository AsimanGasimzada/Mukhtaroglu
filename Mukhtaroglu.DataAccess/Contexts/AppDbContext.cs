using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mukhtaroglu.Core.Entities;

namespace Mukhtaroglu.DataAccess.Contexts;
internal class AppDbContext : IdentityDbContext<IdentityUser>
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Slider> MyProperty { get; set; }

}
