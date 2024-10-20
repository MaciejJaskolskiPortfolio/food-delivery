using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.Auth
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "User Name is required")]
        [MinLength(3, ErrorMessage = "User Name must have at least 3 characters")]
        [MaxLength(16, ErrorMessage = "User Name must have at most 16 characters")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must have at least 8 characters")]
        [MaxLength(16, ErrorMessage = "Password must have at most 16 characters")]
        //[AtLeastOneUppercase]
        //[AtLeastOneNumber]
        //[AtLeastOneSpecialCharacter]
        public string Password { get; set; }

        public RegisterDto() { }
    }
}
