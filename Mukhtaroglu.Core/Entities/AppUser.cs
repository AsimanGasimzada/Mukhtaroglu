using Microsoft.AspNet.Identity.EntityFramework;

namespace Mukhtaroglu.Core.Entities;

public class AppUser : IdentityUser
{
    public string Fullname { get; set; } = null!;
}