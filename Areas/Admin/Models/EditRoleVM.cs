using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdvancedSchoolManagment.Areas.Admin.Models
{
    public class EditRoleVM
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Role name is required")]
        public string Name { get; set; }
        public List<string> Users { get; set; }

        public EditRoleVM(){
            Users= new List<string>();
        }
    }
}
