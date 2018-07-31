using System.ComponentModel.DataAnnotations;

namespace bicycles.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name - letters only, at least 2 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First Name can only contain letters")]
        [MinLength(2)]
        public string FN { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name - letters only, at least 2 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last Name can only contain letters")]
        [MinLength(2)]
        public string LN { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Valid Email format")]
        [RegularExpression(@"^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password - at least 8 characters")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation must match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}