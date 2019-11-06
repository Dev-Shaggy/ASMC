using System;
using System.ComponentModel.DataAnnotations;

namespace AdvancedSchoolManagment.Areas.Identity.Models
{
    public class LoginVM
    {
        [Required]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name="Remember me")]
        public bool RememberMe { get; set; }
    }
}
