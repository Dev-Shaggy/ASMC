using System;
using System.ComponentModel.DataAnnotations;

namespace AdvancedSchoolManagment.Areas.Identity.Models
{
    public class RegisterVM
    {
        [Required]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",ErrorMessage="Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
