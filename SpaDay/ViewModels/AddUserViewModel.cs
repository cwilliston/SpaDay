using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(15, MinimumLength = 5)]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Verify password is required")]
        public string VerifyPassword { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        


    }
}
