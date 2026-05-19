using Microsoft.AspNetCore.Identity;

namespace KT9_ASP.NET.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
    }
}