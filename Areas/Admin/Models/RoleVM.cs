using System;
using System.ComponentModel.DataAnnotations;

namespace AdvancedSchoolManagment.Areas.Admin.Models
{
    public class RoleVM
    {
        [Required]
        public string Name { get; set; }
    }
}
