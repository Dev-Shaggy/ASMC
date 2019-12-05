using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdvancedSchoolManagment.Areas.Admin.Models
{
    public class UserRoleVM
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public bool IsSelected { get; set; }
    }
}
