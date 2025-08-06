using System.ComponentModel.DataAnnotations;

namespace RoleAuthApp.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
