using Microsoft.AspNetCore.Identity;

namespace RoleAuthApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Add any additional properties you want to store for the user

        public string? FullName { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
