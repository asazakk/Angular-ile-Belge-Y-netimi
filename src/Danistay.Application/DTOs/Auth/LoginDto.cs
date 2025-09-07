using System.ComponentModel.DataAnnotations;

namespace Danistay.Application.DTOs.Auth
{
    public class LoginDto
    {
        [Required]
        [StringLength(100)]
        public string Username { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100)]
        public string Password { get; set; } = string.Empty;
    }
}
