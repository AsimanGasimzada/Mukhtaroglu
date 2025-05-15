using Microsoft.AspNetCore.Identity;

namespace Mukhtaroglu.Core.Entities;

public class AppUser : IdentityUser
{
    public string Fullname { get; set; } = null!;
}